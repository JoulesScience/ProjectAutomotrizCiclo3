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
    public class DetailsModel2 : PageModel
    {
        private  readonly IRepositorioTecnico _repo;
        public Tecnico Tecnico { get; set; }
        public DetailsModel2(IRepositorioTecnico repositorio){
        _repo = repositorio;
        }
        public void OnGet(int id)
        {
        Tecnico = _repo.Get(id);
    
        }
    }
}
