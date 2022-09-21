using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio
{
    public class Factura
    {
        [Key]
        public int Factura_id { get; set; }
        [ForeignKey("Cliente")]
        public int Id { get; set; } //Cliente_id
        [ForeignKey("Tecnico")]
        public int Tecnico_id { get; set; }  //Tecnico_id
        [ForeignKey("Vehiculo")]
        public int placa_id { get; set; }
        public DateTime Fecha { get; set; }
        public bool filtro_aire { get; set; }
        public bool filtro_Gasolina { get; set; }
        public bool Cambio_aceite { get; set; }
        public string Observaciones { get; set; }
        public int Total { get; set; }

        public virtual Vehiculo Vehiculo { get; set; }  
        public virtual Tecnico Tecnico { get; set; }  
        public virtual Cliente Cliente { get; set; }  

        
    }
}