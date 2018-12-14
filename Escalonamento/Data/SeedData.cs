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
        public static void Populate(EscalonamentoContext db)
        {
            SeedDataVeiculos(db);
            SeeeDataMarca(db);
        }

   

        private static void SeedDataVeiculos(EscalonamentoContext db)
        {
            if (db.Veiculos.Any()) return;
            Marca marca = GetMarcaCreatingIfNeed(db, "Ford Mondeo");
            CriarVeiculoSenaoExixte(db, "67-33-WQ", marca, true);
            CriarVeiculoSenaoExixte(db, "07-13-WR", marca, true);
             marca = GetMarcaCreatingIfNeed(db, "Mercedes Benz CLA");
            CriarVeiculoSenaoExixte(db, "67-39-KK", marca, true);
            CriarVeiculoSenaoExixte(db, "07-53-KR", marca, true);
            marca = GetMarcaCreatingIfNeed(db, "Peugeot 308");
            db.Veiculos.AddRange(
                new Veiculos { MarcaId = marca.MarcaId, NumMatricula = "25-33-XQ", Disponibilidade = true },
                new Veiculos { MarcaId = marca.MarcaId, NumMatricula = "56-00-TQ", Disponibilidade = true },
                 new Veiculos { MarcaId = marca.MarcaId, NumMatricula = "00-10-RO", Disponibilidade = false }

                 );
            db.SaveChanges();



        }

        private static Veiculos CriarVeiculoSenaoExixte(EscalonamentoContext db, string Matricula, Marca marca, bool Disponibilidade)
        {
            Veiculos veiculos = db.Veiculos.SingleOrDefault(b => b.NumMatricula == Matricula);      


            if (veiculos == null)
            {
                db.Veiculos.Add(new Veiculos{ NumMatricula = Matricula, MarcaId = marca.MarcaId,Disponibilidade=true });
            }

            return veiculos;
        }
        
        private static Marca GetMarcaCreatingIfNeed(EscalonamentoContext db, string nome)
        {
            Marca marca = db.Marca.SingleOrDefault(a => a.Nome == nome);

            if (marca == null)
            {
               marca = new Marca { Nome = nome };
                db.Add(marca);
                db.SaveChanges();
            }

            return marca;
        }
        private static void SeeeDataMarca(EscalonamentoContext db)
        {
            if (!db.Marca.Any())
            {
                db.Marca.AddRange
                (new Marca { Nome = "Ford Mondeo" },
                new Marca { Nome = "Mercedes Benz CLA" },
                new Marca { Nome = "Volvo V60" },
                new Marca { Nome = "Toyota Auris" },
                new Marca { Nome = "Peugeot 308" },
                new Marca { Nome = "Skoda Octavia" }
                );
             db.SaveChanges();
            }
            return;
           
        }

    }
}


