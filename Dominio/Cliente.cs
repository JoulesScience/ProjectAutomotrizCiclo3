using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Cliente
    {
        [Key]
        public int Id{ get; set; }
        public int Factura_id { get; set; }
        
        [ForeignKey("Persona")]
        public int Identificaion_id { get; set; }
        public int placa_id { get; set; }

        public virtual Persona Persona { get; set; }
        
    }
}