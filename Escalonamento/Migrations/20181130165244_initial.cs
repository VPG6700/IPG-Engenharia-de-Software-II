using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Escalonamento.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarcaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Modelo = table.Column<string>(nullable: false),
                    Ano = table.Column<int>(nullable: false),
                    Especificacoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "medico",
                columns: table => new
                {
                    MedicoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    NumMatricula = table.Column<string>(nullable: false),
                    Disponibilidade = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medico", x => x.MedicoID);
                });

            migrationBuilder.CreateTable(
                name: "Trocas",
                columns: table => new
                {
                    TrocasId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome1 = table.Column<string>(nullable: false),
                    Dia1 = table.Column<DateTime>(nullable: false),
                    Turno1 = table.Column<string>(nullable: false),
                    Nome2 = table.Column<string>(nullable: false),
                    Dia2 = table.Column<DateTime>(nullable: false),
                    Turno2 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trocas", x => x.TrocasId);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Marca = table.Column<string>(nullable: false),
                    NumMatricula = table.Column<string>(nullable: false),
                    Disponibilidade = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculosId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "medico");

            migrationBuilder.DropTable(
                name: "Trocas");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
