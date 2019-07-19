using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Tutor
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public String Nomnbre { get; set; }

        [Required]
        [StringLength(20)]
        public String Apellido { get; set; }

        [Required]
        [StringLength(100)]
        public String Direccion { get; set; }

        [Required]
        [StringLength(100)]
        public String Correo { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 12)]
        public String Telefono { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public Estado EstadoId { get; set; }


    }
}
