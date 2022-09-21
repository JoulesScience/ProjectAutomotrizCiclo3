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
        [ForeignKey("Factura")]
        public int Factura_id { get; set; }
        
        [ForeignKey("Persona")]
        public int Identificaion_id { get; set; }
        
        [ForeignKey("Vehiculo")]
        public int placa_id { get; set; }

        public virtual Persona Persona { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual Factura Factura { get; set; }

        public List<Auto> Autos { get; set;}
        public List<Camioneta> Camionetas { get; set;}
        public List<Factura> Facturas { get; set;}

        
    }
}