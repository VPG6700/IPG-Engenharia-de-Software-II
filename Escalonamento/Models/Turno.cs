using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Turno
    {
        [Key]
        public int TurnoId { get; set; }
        [Required]
        private DateTime Turnos { get; set; }
    }
}
