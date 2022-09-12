using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioCamioneta
    {
     Camioneta Add(Camioneta camioneta); //  Create, Crear adicionar 
     IEnumerable<Camioneta> GetAll(); // Read, leer o buscar listas
     Camioneta Get(int idCamioneta); // Read, Leer o buscar una camioneta por id
     Camioneta Update(Camioneta camioneta); // Update, actulizar datos
     void Delete(int idCamioneta); //Delete, eleminar por id
    
    }
}

