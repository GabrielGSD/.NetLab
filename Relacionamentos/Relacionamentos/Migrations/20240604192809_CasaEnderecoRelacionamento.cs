using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Relacionamentos.Migrations
{
    /// <inheritdoc />
    public partial class CasaEnderecoRelacionamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CasaId",
                table: "Endereco",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_CasaId",
                table: "Endereco",
                column: "CasaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Casas_CasaId",
                table: "Endereco",
                column: "CasaId",
                principalTable: "Casas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Casas_CasaId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_CasaId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "CasaId",
                table: "Endereco");
        }
    }
}
