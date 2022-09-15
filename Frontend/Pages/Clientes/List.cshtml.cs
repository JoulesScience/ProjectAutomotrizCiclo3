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
    public class ListModel1 : PageModel
    { 
        private  readonly IRepositorioCliente _repo;
        public IEnumerable<Cliente> Clientes { get; set; }
        public ListModel1(IRepositorioCliente repositorio){
            _repo = repositorio;
        }
        public void OnGet()
        {
           Clientes=_repo.GetAll();
                   
        }
    }
}