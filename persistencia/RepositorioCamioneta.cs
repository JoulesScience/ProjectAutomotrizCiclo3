using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioCamioneta: IRepositorioCamioneta
    {
        private readonly ApplicationContext _applicationContext;
        public RepositorioCamioneta(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }
        public RepositorioCamioneta(){

        }
        //implementado repositorio sirve para guardar datos en base de datos
        Auto IRepositorioCamioneta.Add(Camioneta camioneta){
            var  new_camioneta = _applicationContext.camionetas.Add(auto);
            _applicationContext.SaveChanges();
            return new_camioneta.Entity;
        }
        //implementado repositorio Read, leer o buscar listas
        IEnumerable<Camioneta> IRepositorioCamioneta.GetAll(){
            return _applicationContext.camionetas;
        }
        //implementado repositorio  Read, Leer o buscar una camioneta por id
        Auto IRepositorioCamioneta.Get(int idCamioneta){
            return  _applicationContext.camionetas.FirstOrDefault(
                c => c.Id == idCamioneta);
        }
        //implementado repositorio Update, actulizar datos
        Auto IRepositorioCamioneta.Update(Camioneta camioneta){
            var camioneta_encontrada = _applicationContext.camionetas.FirstOrDefault(
                c => c.Id == camioneta.Id);
            if(camioneta_encontrada != null){
                camioneta_encontrada.Platon = camioneta.Platon;
                camioneta_encontrada.Transmision = camioneta.Transmision;
                camioneta_encontrada.placa_id  = camioneta.placa_id;                
                }
            _applicationContext.SaveChanges();
            return camioneta_encontrada;
        }    
        //implementado repositorio Delete 
        void IRepositorioCamioneta.Delete(int idCamioneta){
            var  camioneta_encontrada = _applicationContext.autos.FirstOrDefault(
                c => c.Id == idCamioneta);
            if(camioneta_encontrada== null){
                return;
                }
            _applicationContext.Remove(camioneta_encontrada);
            _applicationContext.SaveChanges();
        }   
       
    }
}