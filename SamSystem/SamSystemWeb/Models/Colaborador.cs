using SamSystemWeb.Data;
using System;
using System.ComponentModel.DataAnnotations;

namespace SamSystemWeb.Models
{
    public class Colaborador
    {
        [Required]
        public AppUser Colaboradorr { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public String Apellido { get; set; }

        [Required]
        [StringLength(3,MinimumLength  =2)]
        public short Edad { get; set; }

        [Required]
        public char Sexo { get; set; }

        [Required]
        [StringLength(8)]
        public string EstadoCivil { get; set; }

        [Required]
        [StringLength(10)]
        public int Telefono { get; set; }

        [Required]
        [StringLength(100)]
        public String Correo { get; set; }

        [Required]
        [StringLength(100)]
        public String Direccion { get; set; }

        [Required]
        [StringLength(100)]
        public String Cargo { get; set; }

    }
}
