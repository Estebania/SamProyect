using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class FormaDePago
    {
        [Required]
        public short ID { get; set; }

        [Required]
        [StringLength(15)]
        public String Pago { get; set; }

        [Required]
        public Double Cuota { get; set; }




    }
}
