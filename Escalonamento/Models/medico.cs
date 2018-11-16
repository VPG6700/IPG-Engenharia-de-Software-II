using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class medico
    {
        [Required]
        public int MedicoID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string NumMatricula { get; set; }

        [Required]
        public string Disponibilidade { get; set; }
    }
}
