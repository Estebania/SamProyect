using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class DetalleRetencion
    {
        [Required]
        public Retencion RetencionId { get; set; }

        [Required]
        public Articulos ArticulosId { get; set; }
    }
}
