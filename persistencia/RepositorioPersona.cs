using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;
using System.ComponentModel.DataAnnotations;


namespace persistencia
{
    public class RepositorioPersona: IRepositorioPersona
    {
        private readonly ApplicationContext _applicationContext;
        public RepositorioPersona(ApplicationContext applicationContext){
            _applicationContext = applicationContext;
        }
        public RepositorioPersona(){

        }
        //implementado repositorio sirve para guardar datos en base de datos
        Persona IRepositorioPersona.Add(Persona persona){
            var  new_persona = _applicationContext.personas.Add(persona);
            _applicationContext.SaveChanges();
            return new_persona.Entity;
        }
        //implementado repositorio Read, leer o buscar listas
        IEnumerable<Persona> IRepositorioPersona.GetAll(){
            return _applicationContext.personas;
        }
        //implementado repositorio  Read, Leer o buscar un persona por id
        Persona IRepositorioPersona.Get(int idPersona){
            return  _applicationContext.personas.FirstOrDefault(
                p => p.Identificaion_id == idPersona); //p.CedulaId
        }
        //implementado repositorio Update, actulizar datos
        Persona IRepositorioPersona.Update(Persona persona){
            var  persona_encontrada = _applicationContext.personas.FirstOrDefault(
                p => p.Identificaion_id == persona.Identificaion_id); // p.CedulaId== persona.CedulaId
                Console.WriteLine(persona.Nombres + " " + persona.Apellidos + " " + persona.Identificaion_id);

            if(persona_encontrada != null){
                persona_encontrada.Nombres = persona.Nombres;
                persona_encontrada.Apellidos = persona.Apellidos;
                persona_encontrada.Direccion  = persona.Direccion;
                persona_encontrada.Celular   = persona.Celular;
                }
            _applicationContext.SaveChanges();
            return persona_encontrada;
        }    
        //implementado repositorio Delete 
        void IRepositorioPersona.Delete(int idPersona){
            var  persona_encontrada = _applicationContext.personas.FirstOrDefault(
                p => p.Identificaion_id == idPersona); //p.CedulaId 
            if(persona_encontrada== null){
                return;
                }
            _applicationContext.Remove(persona_encontrada);
            _applicationContext.SaveChanges();
        }   
       
    }
}