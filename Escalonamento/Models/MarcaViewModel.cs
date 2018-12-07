using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class MarcaViewModel
    {
        public IEnumerable<Marca> Marcas { get; set; }
        public PagingViewModel Pagination { get; set; }

        [DisplayName("Veículo")]
        public string CurrentModel { get; set; }
    }
}
