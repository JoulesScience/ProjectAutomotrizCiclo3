using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using persistencia;

namespace MyApp.Namespace
{
    public class ListModel3 : PageModel
    { 
        private readonly IRepositorioVehiculo _repo;
        public IEnumerable<Vehiculo> Vehiculos { get; set; }
        public ListModel3(IRepositorioVehiculo repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        {
           Vehiculos = _repo.GetAll();
                   
        }
    }
}
