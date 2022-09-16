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
    public class DeleteModel4 : PageModel
    {
        private  readonly IRepositorioAuto _repo;
        public Auto Auto { get; set; }
        public DeleteModel4(IRepositorioAuto repositorio){
            _repo = repositorio;
        }
        public void OnGet(int id)
        {
            Auto = _repo.Get(id);
            
        }
         public IActionResult OnPost(int id){
            _repo.Delete(id);
            return new RedirectToPageResult("/Autos/List");
        }
    }
}
