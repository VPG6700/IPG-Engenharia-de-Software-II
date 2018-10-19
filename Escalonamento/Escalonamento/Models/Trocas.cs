using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Trocas
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome1 { get; set; }
        [Required]
        public string Turno1 { get; set; }
        [Required]
        public string Nome2 { get; set; }
        [Required]
        public string Turno2 { get; set; }
    }
}
