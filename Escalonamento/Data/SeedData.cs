using Escalonamento.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escalonamento.Data
{
    public static class SeedData
    {
        public static void Populate(IServiceProvider applicationServices)
        {
            using
            (var serviceScope = applicationServices.CreateScope())
            {
                var db = serviceScope.ServiceProvider.GetService<EscalonamentoContext>();
                
                if (!db.Marca.Any())
                {
                    db.Marca.AddRange
                    (new Marca { Nome = "Ford Mondeo"},
                    new Marca { Nome = "Mercedes Benz CLA"},
                    new Marca { Nome = "Volvo V60" },
                    new Marca { Nome = "Toyota Auris" },
                    new Marca { Nome = "Peugeot 308" },
                    new Marca { Nome = "Volkswagen Passat" },
                    new Marca { Nome = "Skoda Octavia" }
                    );
                }
                db.SaveChanges();

                
            }
        }
    }
}

