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
    public class UpdateModel1 : PageModel
    {
    private  readonly IRepositorioCliente _repo;
    public Cliente Cliente { get; set; }
    public UpdateModel1(IRepositorioCliente repositorio){
        _repo = repositorio;
    }
    
    public void OnGet(int Id)
    { 
       Cliente = _repo.Get(Id);
    }
    public IActionResult OnPost(Cliente cliente){
                
        _repo.Update(cliente);
        return new RedirectToPageResult("/Clientes/List");
    }
    }
}
