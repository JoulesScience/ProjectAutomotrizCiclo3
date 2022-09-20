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
    public class ListModel5 : PageModel
    { 
        private  readonly IRepositorioCamioneta _repo;
        public IEnumerable<Camioneta> Camionetas { get; set; }
        public ListModel5(IRepositorioCamioneta repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        {
           Camionetas=_repo.GetAll();
                   
        }
    }
}
