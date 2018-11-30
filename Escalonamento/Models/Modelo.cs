using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Modelo
    {
        [Key]
        public int ModeloId { get; set; }
        [Required(ErrorMessage = "Introduza o nome do modelo")]
        //[RegularExpression(@"[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:]", ErrorMessage = "Nome Inválido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Introduza o ano do modelo")]
        [RegularExpression(@"(20\d{2})", ErrorMessage = "Ano Inválido")]
        public int Ano { get; set; }


        [Required(ErrorMessage = "Introduza a marca do modelo")]
        public Marca Marca { get; set; }
        [ForeignKey("MarcaId")]
        public int MarcaId { get; set; }


    }
}
