using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioPersona
    {
     Persona Add(Persona persona); //  Create, Crear adicionar 
     IEnumerable<Persona> GetAll(); // Read, leer o buscar listas
     Persona Get(int idPersona); // Read, Leer o buscar un persona por id
     Persona Update(Persona persona); // Update, actulizar datos
     void Delete(int idPersona); //Delete, eleminar por id


    
    }
}