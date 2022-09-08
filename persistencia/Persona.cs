using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
        public class Persona: IPersona
        {
            private readonly ApplicationContext _applicationContext;

            public Persona(ApplicationContext applicationContext){
                _applicationContext = applicationContext;

            } 

            public Persona(){}

            Persona IPersona.Add(Persona persona)                     
            {
                var new_persona = _applicationContext.personas.Add(persona);
                _applicationContext.SaveChanges();
                return new_persona.Entity;

            }

            void IPersona.Delete(int idPersona)
            {
                var personaEncontrada = _applicationContext.personas.FirstOrDefault(
                    p => p.Id == idPersona
                );

                if(personaEncontrada == null)
                return;
                _applicationContext.Remove(personaEncontrada);
                _applicationContext.SaveChanges();
            }

            IEnumerable<Persona> IPersona.GetAll(){
                return _applicationContext.personas;
            }

            Persona IPersona.Get(int IdPersona){
                return _applicationContext.personas.FirstOrDefault(
                    p => p.Id == IdPersona
                );                 
            }   

            Persona IPersona.Update(Persona persona){
                var personaEncontrada = _applicationContext.personas.FirstOrDefault(
                    p => p.Id == persona.Id
                );

                if(personaEncontrada != null){
                  personaEncontrada.Nombres = persona.Nombres;
                  personaEncontrada.Apellidos = persona.Apellidos;
                  personaEncontrada.Direccion = persona.Direccion;
                  personaEncontrada.Celular = persona.Celular;

                } 
                _applicationContext.SaveChanges();
                return personaEncontrada;   
            }      

        }

}