using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Tecnico
    {   
        [Key]
        public int Tecnico_id { get; set; }
        public string Especialidad { get; set; }
        [ForeignKey("Persona")]
        public int Identificaion_id { get; set; }
       
        public virtual Persona Persona { get; set; }
        
    }
}