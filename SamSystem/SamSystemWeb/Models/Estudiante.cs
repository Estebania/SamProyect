using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Estudiante
    {
       
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public String Nombre { get; set; }

        [Required]
        [StringLength(20)]
        public String Apellido { get; set; }


        public DateTime FechaDeNacimiento { get; set; }

        [Required]
        [StringLength(100)]
        public String Correo { get; set; }

        [Required]
        [StringLength(100)]
        public String Direccion { get; set; }

        [Required]
        [StringLength(12, MinimumLength = 12)]
        public String Telefono { get; set; }

        [Required]
        public Seccion SeccionId { get; set; }

        [Required]
        public Tutor TutorId { get; set; }

        [Required]
        public FormaDePago FormaDePagoId { get; set; }

        [Required]
        public Estado EstadoId { get; set; }

        [Required]
        public Nivel NivelId { get; set; }
    }
}
