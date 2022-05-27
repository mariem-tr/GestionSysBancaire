using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetArchitecture.Migrations
{
    public partial class modifclient1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NomPrenom",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomPrenom",
                table: "Clients");
        }
    }
}
