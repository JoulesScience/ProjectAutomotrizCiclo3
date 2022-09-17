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
    public class DetailsModel5 : PageModel
    {
        private  readonly IRepositorioCamioneta _repo;
        public Camioneta Camioneta { get; set; }
        public DetailsModel5(IRepositorioCamioneta repositorio){
        _repo = repositorio;
        }
        public void OnGet(int id)
        {
        Camioneta = _repo.Get(id);
    
        }
    }
}
