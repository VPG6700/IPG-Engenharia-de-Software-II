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
        public int TurnosId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public int HoraInicio { get; set; }
        [Required]
        public int Duracao { get; set; }

    }
}
