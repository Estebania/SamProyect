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
        public int ID { get; set; }
        [Required]
        //[Key]
        //public Retencion RetencionId { get; set; }

       
        public Articulo ArticulosId { get; set; }
    }
}
