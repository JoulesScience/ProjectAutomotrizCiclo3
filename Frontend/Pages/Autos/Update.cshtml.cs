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
    public class UpdateModel4 : PageModel
    {
    private  readonly IRepositorioAuto _repo;
    public Auto Auto { get; set; }
    public UpdateModel4(IRepositorioAuto repositorio){
        _repo = repositorio;
    }
    
    public void OnGet(int Id)
    { 
       Auto = _repo.Get(Id);
    }
    public IActionResult OnPost(Auto auto){
                
        _repo.Update(auto);
        return new RedirectToPageResult("/Autos/List");
    }
    }
}
