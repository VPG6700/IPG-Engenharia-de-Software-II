using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Trocas
    {
        
        [Key]
        public int TrocasId { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        public string Nome1 { get; set; }

        [Required(ErrorMessage = "Selecione o dia")]
        [DataType(DataType.DateTime)]
        public DateTime Dia1 { get; set; }

        [Required(ErrorMessage = "Digite o nome")]
        public string Nome2 { get; set; }

        [Required(ErrorMessage = "Selecione o dia")]
        [DataType(DataType.DateTime)]
        public DateTime Dia2 { get; set; }

        [Required(ErrorMessage = "Selecione o turno")]
        public Turnos Turno { get; set; }
        public int TurnoId { get; set; }

    }
}
