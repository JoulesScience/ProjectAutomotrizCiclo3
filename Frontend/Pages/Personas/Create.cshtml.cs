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
    public class CreateModel : PageModel
    {
        private  readonly IRepositorioPersona _repo;
        public Persona Persona { get; set; }
        public CreateModel(IRepositorioPersona repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        { 
           
        }
        public IActionResult OnPost(Persona persona){

            if (!ModelState.IsValid)
                return Page();
            _repo.Add(persona);
            return new RedirectToPageResult("/Personas/List");
        }
    }
}
