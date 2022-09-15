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
    public class CreateModel2 : PageModel
    {
        private  readonly IRepositorioTecnico _repo;
        public Tecnico Tecnico { get; set; }
        public CreateModel2(IRepositorioTecnico repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        { 
           
        }
        public IActionResult OnPost(Tecnico tecnico){

            if (!ModelState.IsValid)
                return Page();
            _repo.Add(Tecnico);
            return new RedirectToPageResult("/Tecnico/List");
        }
    }
}
