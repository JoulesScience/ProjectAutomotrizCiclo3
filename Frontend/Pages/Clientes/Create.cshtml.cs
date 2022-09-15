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
    public class CreateModel1 : PageModel
    {
        private  readonly IRepositorioCliente _repo;
        public Cliente Cliente { get; set; }
        public CreateModel1(IRepositorioCliente repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        { 
           
        }
        public IActionResult OnPost(Cliente cliente){

            if (!ModelState.IsValid)
                return Page();
            _repo.Add(cliente);
            return new RedirectToPageResult("/Clientes/List");
        }
    }
}
