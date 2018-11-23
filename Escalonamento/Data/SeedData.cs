using Escalonamento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Data
{
    public class SeedData
    {
        public static void Populate(EscalonamentoContext db)
        {
            SeedDataVeiculos(db);
        }

        private static void SeedDataVeiculos(EscalonamentoContext db)
        {
            if (db.Veiculos.Any()) return;

            db.Veiculos.AddRange(
                new Veiculos { Marca = "Mercedes_Bens", NumMatricula = "25-33-XQ", Disponibilidade = true },
                new Veiculos { Marca = "Mercedes_Bens", NumMatricula = "56-00-TQ", Disponibilidade = true },
                 new Veiculos { Marca = "TOYOTA", NumMatricula = "00-10-RO", Disponibilidade = false }

                 );
            db.SaveChanges();

        }
    }
    
}
