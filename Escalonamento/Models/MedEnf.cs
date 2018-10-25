using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class MedEnf
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }
        [Required]
        public string Funcao { get; set; }
        public int Telemovel { get; set; }
        public string Observacoes { get; set; }
    }
}