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
    public class CreateModel3 : PageModel
    {
        private  readonly IRepositorioVehiculo _repo;
        public Vehiculo Vehiculo { get; set; }
        public CreateModel3(IRepositorioVehiculo repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        { 
           
        }
        public IActionResult OnPost(Vehiculo vehiculo){

            if (!ModelState.IsValid)
                return Page();
            _repo.Add(vehiculo);
            return new RedirectToPageResult("/Vehiculo/List");
        }
    }
}
