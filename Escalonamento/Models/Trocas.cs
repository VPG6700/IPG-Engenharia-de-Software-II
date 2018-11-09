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
        [Key]
        public int TrocasId { get; set; }

        [Required]
        public string Nome1 { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Dia1 { get; set; }

        [Required]
        public Turnos Turno1 { get; set; }
        public int IdTurnos { get; set; }

        [Required]
        public string Nome2 { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Dia2 { get; set; }

        [Required]
        public Turnos Turno2 { get; set; }

    }
}
