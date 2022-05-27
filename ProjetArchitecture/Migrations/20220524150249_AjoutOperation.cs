using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetArchitecture.Migrations
{
    public partial class AjoutOperation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Matricule",
                table: "Comptes",
                newName: "NumCompte");

            migrationBuilder.AddColumn<double>(
                name: "Solde",
                table: "Comptes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    OptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompteId = table.Column<int>(type: "int", nullable: false),
                    NumCompte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Montant = table.Column<double>(type: "float", nullable: false),
                    TypeOperation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.OptionId);
                    table.ForeignKey(
                        name: "FK_Operations_Comptes_CompteId",
                        column: x => x.CompteId,
                        principalTable: "Comptes",
                        principalColumn: "CompteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operations_CompteId",
                table: "Operations",
                column: "CompteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.DropColumn(
                name: "Solde",
                table: "Comptes");

            migrationBuilder.RenameColumn(
                name: "NumCompte",
                table: "Comptes",
                newName: "Matricule");
        }
    }
}
