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

       

        public DbSet<Escalonamento.Models.Trocas> Trocas { get; set; }

        public DbSet<Escalonamento.Models.Veiculos> Veiculos { get; set; }

       
        public DbSet<Escalonamento.Models.medico> medico { get; set; }

       
        public DbSet<Escalonamento.Models.Marca> Marca { get; set; }

        public DbSet<Escalonamento.Models.Turnos> Turnos { get; set; }

    }
}
