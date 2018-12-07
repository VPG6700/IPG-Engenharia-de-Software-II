using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }

        [Required(ErrorMessage = "Introduza o nome do veículo")]
        //[RegularExpression(@"([A-Za-záàâãéèêíïóôõöúçñÁÀÂÃÉÈÍÏÓÔÕÖÚÇÑ\s]+)", ErrorMessage = "Nome Inválido")]
        public string Nome { get; set; }

       
    }
}

