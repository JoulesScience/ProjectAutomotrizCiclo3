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
    public class DetailsModel3 : PageModel
    {
        private readonly IRepositorioVehiculo _repo;
        public Vehiculo Vehiculo { get; set; }
        public DetailsModel3(IRepositorioVehiculo repositorio){
        _repo = repositorio;
        }
        public void OnGet(int id)
        {
        Vehiculo = _repo.Get(id);
    
        }
    }
}
