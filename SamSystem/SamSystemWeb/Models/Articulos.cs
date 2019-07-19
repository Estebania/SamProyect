using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Articulo
    {
        [Required]
        public short ID { get; set; }

        [Required]
        [StringLength(20)]
        public String Nombre { get; set; }

        //[Required]        
        //public Proveedor ProveedorId { get; set; }

        [Required]
        public short CantidadDisponible { get; set; }

        [Required]
        public short CantidadRequerida { get; set; }

        [Required]
        public short CantidadASolicitar { get; set; }

        [Required]
        public Double Precio { get; set; }

    }
}
