using SamSystemWeb.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SamSystemWeb.Models
{
    public class Colaborador
    {
        
        
        public int Id { get; set; }

        [Required]
        public AppUser UsuarioID { get; set; }


        [Required]
        [StringLength(20)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public String Apellido { get; set; }

        [Required]
        [StringLength(3,MinimumLength  =2)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public char Sexo { get; set; }

        [Required]
        [StringLength(13)]
        public String Cedula { get; set; }

        [Required]
        [StringLength(10)]
        public string EstadoCivil { get; set; }

        [Required]
        [StringLength(12,MinimumLength  =12)]
        public String Telefono { get; set; }

        [Required]
        [StringLength(100)]
        public String Correo { get; set; }

        [Required]
        [StringLength(100)]
        public String Direccion { get; set; }

        //[Required]
        //[StringLength(100)]
        //public Cargo Cargo { get; set; }

    }
}
