using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Persona
    {
        //[Key][DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int Identificaion_id { get; set; } //CedulaId
        [Required(ErrorMessage="El campo Nombres es requerido"),Display(Name="Nombres"), StringLength(50)]
        public string Nombres { get; set; }
        [Required(ErrorMessage="El campo Apellidos es requerido"),StringLength(50)]
        public string Apellidos { get; set; }
        [Required(ErrorMessage="El campo Direccion es requerido"),StringLength(80)]
        public string Direccion { get; set; }
        [Required(ErrorMessage="El campo Celular es requerido"),StringLength(10)]
        [RegularExpression("[0-9]*$",ErrorMessage="Digite solo numeros")]
        public string Celular { get; set; }
        // relaciones uno a uno con tecnico
        public Tecnico tecnico { get; set; }
        // relaciones uno a uno con cliente
        public Cliente cliente { get; set; }
 
      
      
    }
}
