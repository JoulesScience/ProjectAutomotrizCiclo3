using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio;

namespace persistencia
{
    public interface IRepositorioVehiculo
    {
     Vehiculo Add(Vehiculo vehiculo); //  Create, Crear adicionar 
     IEnumerable<Vehiculo> GetAll(); // Read, leer o buscar listas
     Vehiculo Get(int idVehiculo); // Read, Leer o buscar un Vehiculo por id
     Vehiculo Update(Vehiculo vehiculo); // Update, actulizar datos
     void Delete(int idVehiculo); //Delete, eleminar por id

    }
}

