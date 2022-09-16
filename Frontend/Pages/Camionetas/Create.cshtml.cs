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
    public class CreateModel5 : PageModel
    {
        private  readonly IRepositorioCamioneta _repo;
        public Camioneta Camioneta { get; set; }
        public CreateModel5(IRepositorioCamioneta repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        { 
           
        }
        public IActionResult OnPost(Camioneta camioneta){

            if (!ModelState.IsValid)
                return Page();
            _repo.Add(camioneta);
            return new RedirectToPageResult("/Camionetas/List");
        }
    }
}
