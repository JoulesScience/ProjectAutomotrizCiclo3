using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioAuto: IRepositorioAuto
    {
        private readonly ApplicationContext _applicationContext;
        public RepositorioAuto(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }
        public RepositorioAuto(){

        }
        //implementado repositorio sirve para guardar datos en base de datos
        Auto IRepositorioAuto.Add(Auto auto){
            var  new_auto = _applicationContext.autos.Add(auto);
            _applicationContext.SaveChanges();
            return new_auto.Entity;
        }
        //implementado repositorio Read, leer o buscar listas
        IEnumerable<Auto> IRepositorioAuto.GetAll(){
            return _applicationContext.autos;
        }
        //implementado repositorio  Read, Leer o buscar un auto por id
        Auto IRepositorioAuto.Get(int idAuto){
            return  _applicationContext.autos.FirstOrDefault(
                a => a.Id == idAuto);
        }
        //implementado repositorio Update, actulizar datos
        Auto IRepositorioAuto.Update(Auto auto){
            var auto_encontrada = _applicationContext.autos.FirstOrDefault(
                a => a.Id == auto.Id);
            if(auto_encontrada != null){
                auto_encontrada.Tipo = auto.Tipo;
                auto_encontrada.Transmision = auto.Transmision;
                auto_encontrada.placa_id  = auto.placa_id;                
                }
            _applicationContext.SaveChanges();
            return auto_encontrada;
        }    
        //implementado repositorio Delete 
        void IRepositorioAuto.Delete(int idAuto){
            var  auto_encontrada = _applicationContext.autos.FirstOrDefault(
                a => a.Id == idAuto);
            if(auto_encontrada== null){
                return;
                }
            _applicationContext.Remove(auto_encontrada);
            _applicationContext.SaveChanges();
        }   
       
    }
}