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
    public class UpdateModel : PageModel
  {
    private  readonly IRepositorioPersona _repo;
            
    public UpdateModel(IRepositorioPersona repositorio){
        _repo = repositorio;
    }
    
    public Persona Persona { get; set; }
            

    public void OnGet(int id)
    { 
       Persona = _repo.Get(id);
    }
    public IActionResult OnPost(Persona persona){
                
        _repo.Update(persona);
        return new RedirectToPageResult("/Personas/List");
    }
  }
}
