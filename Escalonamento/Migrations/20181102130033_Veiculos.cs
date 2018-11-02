using Microsoft.EntityFrameworkCore.Migrations;

namespace Escalonamento.Migrations
{
    public partial class Veiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "disponibilidade",
                table: "Veiculos",
                newName: "Disponibilidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Disponibilidade",
                table: "Veiculos",
                newName: "disponibilidade");
        }
    }
}
