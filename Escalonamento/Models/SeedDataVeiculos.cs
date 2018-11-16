using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Models
{
    public class SeedDataVeiculos
    {
        public static void Polular(IServiceProvider ApplicationServices)
        {
            using (var serviceScope = ApplicationServices.CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<EscalonamentoContext>();

                if (db.Veiculos.Any()) return;

                db.Veiculos.AddRange(
                    new Veiculos {  Marca = "Mercedes_Bens",NumMatricula = "25-33-XQ",  Disponibilidade = "ativo" },
                    new Veiculos {Marca = "Mercedes_Bens", NumMatricula = "56-00-TQ",  Disponibilidade = "ativo" },
                     new Veiculos {  Marca = "TOYOTA", NumMatricula = "00-10-RO", Disponibilidade = "ativo" }

                     );
                db.SaveChanges();

            }
        }

        internal static void Polular(object applicationServices)
        {
            throw new NotImplementedException();
        }
    }
}
