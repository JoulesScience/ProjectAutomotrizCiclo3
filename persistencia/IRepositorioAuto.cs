using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioAuto
    {
     Auto Add(Auto auto); //  Create, Crear adicionar 
     IEnumerable<Auto> GetAll(); // Read, leer o buscar listas
     Auto Get(int idAuto); // Read, Leer o buscar un auto por id
     Auto Update(Auto auto); // Update, actulizar datos
     void Delete(int idAuto); //Delete, eleminar por id
    
    }
}

