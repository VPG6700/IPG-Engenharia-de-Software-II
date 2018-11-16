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
                name: "EscalonamentoHorario",
                columns: table => new
                {
                    EscalonamentoHorarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Gerar = table.Column<string>(nullable: false),
                    Visualizar = table.Column<string>(nullable: false),
                    Imprimir = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EscalonamentoHorario", x => x.EscalonamentoHorarioId);
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
                    Disponibilidade = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculosId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EscalonamentoHorario");

            migrationBuilder.DropTable(
                name: "Trocas");

            migrationBuilder.DropTable(
                name: "Veiculos");
        }
    }
}
