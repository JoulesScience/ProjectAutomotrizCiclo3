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
    public class DeleteModel : PageModel
    {
        private  readonly IRepositorioPersona _repo;
        public Persona Persona { get; set; }
        public DeleteModel(IRepositorioPersona repositorio){
            _repo = repositorio;
        }
        public void OnGet(int id)
        {
            _repo.Get(id);
            
        }
         public IActionResult OnPost(int id){
            _repo.Delete(id);
            return new RedirectToPageResult("/Personas/List");
        }
    }
}
