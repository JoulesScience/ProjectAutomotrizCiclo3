using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioCliente    {
     Cliente Add(Cliente cliente); //  Create, Crear adicionar 
     IEnumerable<Cliente> GetAll(); // Read, leer o buscar listas
     Cliente Get(int idCliente); // Read, Leer o buscar un persona por id
     Cliente Update(Cliente cliente); // Update, actulizar datos
     void Delete(int idCliente); //Delete, eleminar por id


    
    }
}