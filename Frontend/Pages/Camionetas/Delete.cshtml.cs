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
    public class DeleteModel5 : PageModel
    {
        private  readonly IRepositorioCamioneta _repo;
        public Camioneta Camioneta { get; set; }
        public DeleteModel5(IRepositorioCamioneta repositorio){
            _repo = repositorio;
        }
        public void OnGet(int id)
        {
            Camioneta = _repo.Get(id);
            
        }
         public IActionResult OnPost(int id){
            _repo.Delete(id);
            return new RedirectToPageResult("/Camionetas/List");
        }
    }
}
