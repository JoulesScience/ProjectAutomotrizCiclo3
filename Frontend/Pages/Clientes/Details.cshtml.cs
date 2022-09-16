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
    public class DetailsModel1 : PageModel
    {
       private  readonly IRepositorioCliente _repo;
        public Cliente Cliente { get; set; }
        public DetailsModel1(IRepositorioCliente repositorio){
        _repo = repositorio;
        }
        public void OnGet(int id)
        {
        Cliente = _repo.Get(id);
    
        }
    }
}
