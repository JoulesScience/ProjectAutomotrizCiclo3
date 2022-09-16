using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace Dominio
{
    public class Factura
    {
        public int Id { get; set; }
        public int Cliente_id { get; set; }
        public int Tecnico_id { get; set; }
        public int Placa_id { get; set; }
        public DateTime Fecha { get; set; }
        public bool filtro_aire { get; set; }
        public bool filtro_Gasolina { get; set; }
        public bool Cambio_aceite { get; set; }
        public string Observaciones { get; set; }
        public int Total { get; set; }
        
    }
}