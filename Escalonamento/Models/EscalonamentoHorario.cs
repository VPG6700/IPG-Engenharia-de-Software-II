using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class EscalonamentoHorario
    {

        [Required]
        public int EscalonamentoHorarioId { get; set; }
        [Required]
        public string Gerar{ get; set; }
        [Required]
        public string Visualizar { get; set; }

        [Required]
        public string Imprimir { get; set; }
    }
}
