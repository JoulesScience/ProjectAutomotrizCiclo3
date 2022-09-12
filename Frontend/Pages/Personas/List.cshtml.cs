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
    public class ListModel : PageModel
    { 
        private  readonly IRepositorioPersona _repo;
        public IEnumerable<Persona> Personas { get; set; }
        public ListModel(IRepositorioPersona repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        {
           Personas=_repo.GetAll();
                   
        }
    }
}
