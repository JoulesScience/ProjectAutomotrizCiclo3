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
    public class UpdateModel2 : PageModel
  {
    private  readonly IRepositorioTecnico _repo;
    public Tecnico Tecnico { get; set; }
    public UpdateModel2(IRepositorioTecnico repositorio){
        _repo = repositorio;
    }
    
    public void OnGet(int Id)
    { 
       Tecnico = _repo.Get(Id);
    }
    public IActionResult OnPost(Tecnico tecnico){
                
        _repo.Update(tecnico);
        return new RedirectToPageResult("/Tecnicos/List");
    }
  }
}
