using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetArchitecture.Migrations
{
    public partial class modifTableClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comptees_Clients_IdClient",
                table: "Comptees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comptees",
                table: "Comptees");

            migrationBuilder.RenameTable(
                name: "Comptees",
                newName: "Comptes");

            migrationBuilder.RenameIndex(
                name: "IX_Comptees_IdClient",
                table: "Comptes",
                newName: "IX_Comptes_IdClient");

            migrationBuilder.AddColumn<string>(
                name: "Adresse",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mail",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumTel",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comptes",
                table: "Comptes",
                column: "CompteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comptes_Clients_IdClient",
                table: "Comptes",
                column: "IdClient",
                principalTable: "Clients",
                principalColumn: "IdClient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comptes_Clients_IdClient",
                table: "Comptes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comptes",
                table: "Comptes");

            migrationBuilder.DropColumn(
                name: "Adresse",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Mail",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "NumTel",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Comptes",
                newName: "Comptees");

            migrationBuilder.RenameIndex(
                name: "IX_Comptes_IdClient",
                table: "Comptees",
                newName: "IX_Comptees_IdClient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comptees",
                table: "Comptees",
                column: "CompteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comptees_Clients_IdClient",
                table: "Comptees",
                column: "IdClient",
                principalTable: "Clients",
                principalColumn: "IdClient");
        }
    }
}
