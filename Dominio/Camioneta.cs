using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class Camioneta
    {
        public int Id { get; set; }
        public bool Platon { get; set; }
        public string Transmision { get; set; }
        [ForeignKey("Vehiculo")]
        public int placa_id { get; set; }
        //Relacion con vehiculo 1 a 1
        public virtual Vehiculo Vehiculo { get; set; }  
        
    }
}