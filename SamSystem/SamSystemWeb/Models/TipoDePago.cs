using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class TipoDePago
    {
        [Required]
        public byte ID { get; set; }

        [Required]
        [StringLength(10)]
        public String Pago { get; set; }


    }
}
