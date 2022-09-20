using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Vehiculo
    {
        [Key]
        public int placa_id { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public string Modelo { get; set; }
        public string Cilindraje { get; set; }
        public string fecha_modelo { get; set; }
        public string tipo_combustible { get; set; }
        public Auto auto { get; set; }
        public Camioneta camioneta { get; set; }

        
    }
}