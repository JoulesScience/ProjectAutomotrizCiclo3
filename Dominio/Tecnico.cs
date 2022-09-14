using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Tecnico
    {   
        public int Id { get; set; }
        public string Especialidad { get; set; }
        public int Identificaion_id { get; set; }
        
    }
}