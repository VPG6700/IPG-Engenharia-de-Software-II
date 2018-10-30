using Microsoft.EntityFrameworkCore.Migrations;

namespace Escalonamento.Migrations
{
    public partial class Trocas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Trocas",
                newName: "TrocasId");

            migrationBuilder.AddColumn<int>(
                name: "Dia1",
                table: "Trocas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Dia2",
                table: "Trocas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dia1",
                table: "Trocas");

            migrationBuilder.DropColumn(
                name: "Dia2",
                table: "Trocas");

            migrationBuilder.RenameColumn(
                name: "TrocasId",
                table: "Trocas",
                newName: "Id");
        }
    }
}
