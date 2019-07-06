using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Maestro
    {
        [Required]
        public short ID { get; set; }

        [Required] 
        public Colaborador colaboradorid { get; set; }

        [Required]
        public Nivel Nivel { get; set; }

        [Required]
        public Estado Estado { get; set; }


    }
}
