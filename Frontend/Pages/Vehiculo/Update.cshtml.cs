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
    public class UpdateModel3 : PageModel
  {
    private  readonly IRepositorioVehiculo _repo;
    public Vehiculo Vehiculo { get; set; }
    public UpdateModel3(IRepositorioVehiculo repositorio){
        _repo = repositorio;
    }
    
    public void OnGet(int Id)
    { 
       Vehiculo = _repo.Get(Id);
    }
    public IActionResult OnPost(Vehiculo vehiculo){
                
        _repo.Update(vehiculo);
        return new RedirectToPageResult("/Vehiculos/List");
    }
  }
}
