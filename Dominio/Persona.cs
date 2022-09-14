using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Persona
    {
        //[Key]
        public int Id { get; set; } //CedulaId
        [Required(ErrorMessage="El campo Nombres es requerido"),Display(Name="Nombres"), StringLength(50)]
        public string Nombres { get; set; }
        [Required(ErrorMessage="El campo Apellidos es requerido"),StringLength(50)]
        public string Apellidos { get; set; }
        [Required(ErrorMessage="El campo Direccion es requerido"),StringLength(80)]
        public string Direccion { get; set; }
        [Required(ErrorMessage="El campo Celular es requerido"),StringLength(10)]
        [RegularExpression("[0-9]*$",ErrorMessage="Digite solo numeros")]
        public string Celular { get; set; }
      
      
    }
}
