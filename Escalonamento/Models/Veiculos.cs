using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Veiculos
    {
        [Key]
        public int VeiculosId { get; set; }
        
        public Marca Marca { get; set; }
        [Required]
        public int MarcaId { get; set; }
        [Required]
        public string NumMatricula { get; set; }

        [Required]
        public bool Disponibilidade { get; set; }
    
}
}
