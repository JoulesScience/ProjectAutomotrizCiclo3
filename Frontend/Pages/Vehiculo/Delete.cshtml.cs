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
    public class DeleteModel3 : PageModel
    {
        private  readonly IRepositorioVehiculo _repo;
        public Vehiculo Vehiculo { get; set; }
        public DeleteModel3(IRepositorioVehiculo repositorio){
            _repo = repositorio;
        }
        public void OnGet(int id)
        {
            Vehiculo = _repo.Get(id);
            
        }
         public IActionResult OnPost(int id){
            _repo.Delete(id);
            return new RedirectToPageResult("/Vehiculo/List");
        }
    }
}
