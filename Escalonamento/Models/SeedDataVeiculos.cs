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
                    new Veiculos { VeiculosId = 1, NumMatricula = "25.33.XQ", Marca = "Mercedes_Bens", Disponibilidade = "ativo" },
                    new Veiculos { VeiculosId = 122, NumMatricula = "56.00.TQ", Marca = "Mercedes_Bens", Disponibilidade = "ativo" },
                     new Veiculos { VeiculosId = 2, NumMatricula = "00.10.RO", Marca = "TOYOTA", Disponibilidade = "ativo" }

                     );
            }
        }

        internal static void Polular(object applicationServices)
        {
            throw new NotImplementedException();
        }
    }
}
