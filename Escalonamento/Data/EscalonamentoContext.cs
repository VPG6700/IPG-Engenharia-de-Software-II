using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Escalonamento.Models;

namespace Escalonamento.Models
{
    public class EscalonamentoContext : DbContext
    {
        public EscalonamentoContext (DbContextOptions<EscalonamentoContext> options)
            : base(options)
        {
        }

        public DbSet<Escalonamento.Models.MedEnf> MedEnf { get; set; }

        public DbSet<Escalonamento.Models.Troca> Troca { get; set; }

        public DbSet<Escalonamento.Models.Turno> Turno { get; set; }
    }
}
