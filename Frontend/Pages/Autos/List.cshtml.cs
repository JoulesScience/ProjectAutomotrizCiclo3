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
    public class ListModel4 : PageModel
    { 
        private  readonly IRepositorioAuto _repo;
        public IEnumerable<Auto> Autos { get; set; }
        public ListModel4(IRepositorioAuto repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        {
           Autos=_repo.GetAll();
                   
        }
    }
}
