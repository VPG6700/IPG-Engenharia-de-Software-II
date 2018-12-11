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
        public string Nome { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime HoraInicio { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime HoraFim { get; set; }

    }
}
