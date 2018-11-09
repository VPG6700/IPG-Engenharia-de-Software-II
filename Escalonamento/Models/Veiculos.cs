using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Veiculos
    {

        [Required]
        public int VeiculosId { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public string NumMatricula { get; set; }
       
        [Required]
        public string Disponibilidade { get; set; }
    }
}
