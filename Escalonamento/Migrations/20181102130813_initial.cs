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
                name: "MedEnf",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    DataNasc = table.Column<DateTime>(nullable: false),
                    Funcao = table.Column<string>(nullable: false),
                    Telemovel = table.Column<int>(nullable: false),
                    Observacoes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedEnf", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Troca",
                columns: table => new
                {
                    TrocaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome1 = table.Column<string>(nullable: false),
                    Dia1 = table.Column<int>(nullable: false),
                    Turno1 = table.Column<string>(nullable: false),
                    Nome2 = table.Column<string>(nullable: false),
                    Dia2 = table.Column<int>(nullable: false),
                    Turno2 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Troca", x => x.TrocaId);
                });

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    TurnoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.TurnoId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedEnf");

            migrationBuilder.DropTable(
                name: "Troca");

            migrationBuilder.DropTable(
                name: "Turno");
        }
    }
}
