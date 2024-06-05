using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relacionamentos.Migrations
{
    /// <inheritdoc />
    public partial class RenomeandoQuartoTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuartoModel_Casas_CasaId",
                table: "QuartoModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuartoModel",
                table: "QuartoModel");

            migrationBuilder.RenameTable(
                name: "QuartoModel",
                newName: "Quarto");

            migrationBuilder.RenameIndex(
                name: "IX_QuartoModel_CasaId",
                table: "Quarto",
                newName: "IX_Quarto_CasaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quarto",
                table: "Quarto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Quarto_Casas_CasaId",
                table: "Quarto",
                column: "CasaId",
                principalTable: "Casas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quarto_Casas_CasaId",
                table: "Quarto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quarto",
                table: "Quarto");

            migrationBuilder.RenameTable(
                name: "Quarto",
                newName: "QuartoModel");

            migrationBuilder.RenameIndex(
                name: "IX_Quarto_CasaId",
                table: "QuartoModel",
                newName: "IX_QuartoModel_CasaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuartoModel",
                table: "QuartoModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuartoModel_Casas_CasaId",
                table: "QuartoModel",
                column: "CasaId",
                principalTable: "Casas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
