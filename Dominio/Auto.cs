using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class Auto
    {
        public int Id{ get; set; }
        public string Tipo { get; set; }
        public string  Transmision { get; set; }
        [ForeignKey("Vehiculo")]   
        public int placa_id { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }  
        
    }
}