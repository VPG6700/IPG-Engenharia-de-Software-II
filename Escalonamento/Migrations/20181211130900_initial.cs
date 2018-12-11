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
                    Nome = table.Column<string>(nullable: false)
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
                name: "Turno",
                columns: table => new
                {
                    TurnoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    HoraInicio = table.Column<DateTime>(nullable: false),
                    HoraFim = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.TurnoId);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    VeiculosId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MarcaId = table.Column<int>(nullable: false),
                    NumMatricula = table.Column<string>(nullable: false),
                    Disponibilidade = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.VeiculosId);
                    table.ForeignKey(
                        name: "FK_Veiculos_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_MarcaId",
                table: "Veiculos",
                column: "MarcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "medico");

            migrationBuilder.DropTable(
                name: "Trocas");

            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
