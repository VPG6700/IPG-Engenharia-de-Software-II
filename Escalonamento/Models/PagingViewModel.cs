using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class PagingViewModel
    {
        public int Totaltems { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int NumberPages => (int)Math.Ceiling((double)Totaltems / PageSize);
    }
}
