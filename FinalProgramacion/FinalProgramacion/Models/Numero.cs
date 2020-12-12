using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProgramacion.Models
{
    public class Numero
    {
        [Key]
        [Required]
        public int numero { get; set; }
        [Required]
        public string mensaje { get; set; }

    }
}
