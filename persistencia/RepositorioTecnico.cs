using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public class RepositorioTecnico: IRepositorioTecnico
    {
        private readonly ApplicationContext _applicationContext;
        public RepositorioTecnico(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }
        public RepositorioTecnico(){

        }
        //implementado repositorio sirve para guardar datos en base de datos
        Tecnico IRepositorioTecnico.Add(Tecnico tecnico){
            var  new_tecnico = _applicationContext.tecnicos.Add(tecnico);
            _applicationContext.SaveChanges();
            return new_tecnico.Entity;
        }
        //implementado repositorio Read, leer o buscar listas
        IEnumerable<Tecnico> IRepositorioTecnico.GetAll(){
            return _applicationContext.tecnicos;
        }
        //implementado repositorio  Read, Leer o buscar un persona por id
        Tecnico IRepositorioTecnico.Get(int idTecnico){
            return  _applicationContext.tecnicos.FirstOrDefault(
                t => t.Tecnico_id == idTecnico);
        }
        //implementado repositorio Update, actulizar datos
        Tecnico IRepositorioTecnico.Update(Tecnico tecnico){
            var  tecnico_encontrada = _applicationContext.tecnicos.FirstOrDefault(
                t => t.Tecnico_id == tecnico.Tecnico_id);
            if(tecnico_encontrada != null){
                tecnico_encontrada.Especialidad = tecnico.Especialidad;
                tecnico_encontrada.Identificaion_id = tecnico.Identificaion_id;                
                }
            _applicationContext.SaveChanges();
            return tecnico_encontrada;
        }    
        //implementado repositorio Delete 
        void IRepositorioTecnico.Delete(int idTecnico){
            var  tecnico_encontrada = _applicationContext.tecnicos.FirstOrDefault(
                t => t.Tecnico_id == idTecnico);
            if(tecnico_encontrada== null){
                return;
                }
            _applicationContext.Remove(tecnico_encontrada);
            _applicationContext.SaveChanges();
            
        }   
       
    }
}