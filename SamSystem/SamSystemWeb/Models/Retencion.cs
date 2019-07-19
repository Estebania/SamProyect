using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Retencion
    {

        [Required]
        public int ID { get; set; }

        [Required]
        public short CantidadDeArticulos { get; set; }

        [Required]
        public Estudiante EstudianteId { get; set; }

        [Required]
        public Double MontoAPagar { get; set; }

        [Required]
        public Estado EstadoId { get; set; }


    }
}
