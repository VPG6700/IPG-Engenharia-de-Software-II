using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }
        [Required(ErrorMessage = "Introduza o nome da marca")]
        //[RegularExpression(@"[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:]", ErrorMessage = "Nome Inválido")]
        public string Nome { get; set; }


        
    }
}
