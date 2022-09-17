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
    public class DetailsModel4 : PageModel
    {
        private  readonly IRepositorioAuto _repo;
        public Auto Auto { get; set; }
        public DetailsModel4(IRepositorioAuto repositorio){
        _repo = repositorio;
        }
        public void OnGet(int id)
        {
        Auto = _repo.Get(id);
    
        }
    }
}
