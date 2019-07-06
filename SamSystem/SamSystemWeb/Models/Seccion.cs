﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SamSystemWeb.Models
{
    public class Seccion
    {
        [Required]     
        public short id { get; set; }

        public DateTime Horario { get; set; }

        [Required]
        public Maestro Maestroid { get; set; }

        [Required]       
        public short Cupo { get; set; }


    }
}
