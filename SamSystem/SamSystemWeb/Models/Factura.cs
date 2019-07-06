using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Factura
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public int CodigoFactura { get; set; }

        [Required]
        public Double MontoTotal { get; set; }

        [Required]
        public Double Efectivo { get; set; }

        [Required]
        public Double  Cambio { get; set; }

        [Required]
        public Estudiante EstudianteId { get; set; }

        [Required]
        public TipoDePago TipoDePagoId { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

    }
}
