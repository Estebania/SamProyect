using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Estado
    {
        [Required]       
        public byte id { get; set; }

        [Required]
        [StringLength(10)]
        public String Description { get; set; }
    }
}
