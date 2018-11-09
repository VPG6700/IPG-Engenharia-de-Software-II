using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Turnos
    {
        [Key]
        public int IdTurnos { get; set; }

        public string TurnoManha { get; set; }

        public string TurnoTarde { get; set; }

        public string TurnoNoite { get; set; }

        public ICollection<Trocas> Trocas { get; set; }
    }
}
