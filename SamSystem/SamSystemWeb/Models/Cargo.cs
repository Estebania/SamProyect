using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Cargo
    {

        public short id { get; set; }

        [Required]
        [StringLength(15)]
        public String Descripcion { get; set; }
    }
}
