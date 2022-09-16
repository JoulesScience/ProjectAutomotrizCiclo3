using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Cliente
    {
        public int Id{ get; set; }
        public int Factura_id { get; set; }
        public int Identificaion_id { get; set; }
        public int placa_id { get; set; }
        
    }
}