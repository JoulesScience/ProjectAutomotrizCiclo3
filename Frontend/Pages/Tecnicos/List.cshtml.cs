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
    public class ListModel2 : PageModel
    { 
        private  readonly IRepositorioTecnico _repo;
        public IEnumerable<Tecnico> Tecnicos { get; set; }
        public ListModel2(IRepositorioTecnico repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        {
           Tecnicos=_repo.GetAll();
                   
        }
    }
}
