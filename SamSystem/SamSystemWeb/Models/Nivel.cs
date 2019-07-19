using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Nivel
    {
        [Required]
        public short id { get; set; }

        [Required]
        [StringLength(20)]
        public String Descripcion { get; set; }
    }
}
