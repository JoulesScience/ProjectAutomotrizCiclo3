using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioTecnico
    {
     Tecnico Add(Tecnico tecnico); //  Create, Crear adicionar 
     IEnumerable<Tecnico> GetAll(); // Read, leer o buscar listas
     Tecnico Get(int idTecnico); // Read, Leer o buscar un persona por id
     Tecnico Update(Tecnico tecnico); // Update, actulizar datos
     void Delete(int idTecnico); //Delete, eleminar por id
    
    }
}