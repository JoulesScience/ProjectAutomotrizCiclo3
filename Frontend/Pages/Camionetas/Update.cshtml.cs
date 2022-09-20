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
    public class UpdateModel5 : PageModel
    {
    private  readonly IRepositorioCamioneta _repo;
    public Camioneta Camioneta { get; set; }
    public UpdateModel5(IRepositorioCamioneta repositorio){
        _repo = repositorio;
    }
    
    public void OnGet(int Id)
    { 
       Camioneta = _repo.Get(Id);
    }
    public IActionResult OnPost(Camioneta camioneta){
                
        _repo.Update(camioneta);
        return new RedirectToPageResult("/Camionetas/List");
    }
    }
}
