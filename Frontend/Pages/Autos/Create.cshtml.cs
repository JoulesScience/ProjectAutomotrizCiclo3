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
    public class CreateModel4 : PageModel
    {
        private  readonly IRepositorioAuto _repo;
        public Auto Auto { get; set; }
        public CreateModel4(IRepositorioAuto repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        { 
           
        }
        public IActionResult OnPost(Auto auto){

            if (!ModelState.IsValid)
                return Page();
            _repo.Add(auto);
            return new RedirectToPageResult("/Autos/List");
        }
    }
}
