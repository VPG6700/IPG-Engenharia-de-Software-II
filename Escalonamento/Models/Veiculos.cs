using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Veiculos
    {
        [Required]
        public int Id{ get; set; }
        [Required]
        public int NumMatricula { get; set; }
        [Required]
        public string Marca{ get; set; }
   
        public string Disponibilidade { get; set; }
    }
}
