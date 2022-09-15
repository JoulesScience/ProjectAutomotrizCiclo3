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
    public class DeleteModel2 : PageModel
    {
        private  readonly IRepositorioTecnico _repo;
        public Tecnico Tecnico { get; set; }
        public DeleteModel2(IRepositorioTecnico repositorio){
            _repo = repositorio;
        }
        public void OnGet(int id)
        {
            Tecnico = _repo.Get(id);
            
        }
         public IActionResult OnPost(int id){
            _repo.Delete(id);
            return new RedirectToPageResult("/Tecnicoss/List");
        }
    }
}
