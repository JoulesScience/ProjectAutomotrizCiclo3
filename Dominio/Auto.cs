using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Auto
    {
        public int Id{ get; set; }
        public string Tipo { get; set; }
        public string  Transmision { get; set; }
        public int placa_id { get; set; }
          
        
    }
}