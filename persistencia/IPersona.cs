using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
        public interface IPersona
        {

         //Create
         //Read
         //Update
         //Delete
         //Get
         
         Persona Add(Persona persona);
         IEnumerable<Persona> GetAll();
         Persona Update(Persona persona);
         void Delete(int idPersona);
         Persona Get(int idPersona);


        }

}