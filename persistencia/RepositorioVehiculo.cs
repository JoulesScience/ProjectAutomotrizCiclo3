using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioVehiculo: IRepositorioVehiculo
    {
        private readonly ApplicationContext _applicationContext;
        public RepositorioVehiculo(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }
        public RepositorioVehiculo(){

        }
        //implementado repositorio sirve para guardar datos en base de datos
        Vehiculo IRepositorioVehiculo.Add(Vehiculo vehiculo){
            var  new_vehiculo = _applicationContext.vehiculos.Add(vehiculo);
            _applicationContext.SaveChanges();
            return new_vehiculo.Entity;
        }
        //implementado repositorio Read, leer o buscar listas
        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAll(){
            return _applicationContext.vehiculos;
        }
        //implementado repositorio  Read, Leer o buscar un vehiculo por id
        Vehiculo IRepositorioVehiculo.Get(int idVehiculo){
            return  _applicationContext.vehiculos.FirstOrDefault(
                v => v.placa_id == idVehiculo);
        }
        //implementado repositorio Update, actulizar datos
        Vehiculo IRepositorioVehiculo.Update(Vehiculo vehiculo){
            var  vehiculo_encontrada = _applicationContext.vehiculos.FirstOrDefault(
                v => v.placa_id == vehiculo.placa_id);
            if(vehiculo_encontrada != null){
                vehiculo_encontrada.Marca = vehiculo.Marca;
                vehiculo_encontrada.Color = vehiculo.Color;
                vehiculo_encontrada.Modelo  = vehiculo.Modelo;
                vehiculo_encontrada.Cilindraje = vehiculo.Cilindraje;
                vehiculo_encontrada.fecha_modelo = vehiculo.fecha_modelo;
                vehiculo_encontrada.tipo_combustible = vehiculo.tipo_combustible;
                }
            _applicationContext.SaveChanges();
            return vehiculo_encontrada;
        }    
        //implementado repositorio Delete 
        void IRepositorioVehiculo.Delete(int idVehiculo){
            var  vehiculo_encontrada = _applicationContext.vehiculos.FirstOrDefault(
                v => v.placa_id == idVehiculo);
            if(vehiculo_encontrada== null){
                return;
                }
            _applicationContext.Remove(vehiculo_encontrada);
            _applicationContext.SaveChanges();
        }   
       
    }
}

