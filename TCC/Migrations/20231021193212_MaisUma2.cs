using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tcc.Migrations
{
    /// <inheritdoc />
    public partial class MaisUma2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CriancaId",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CriancaId",
                table: "Usuario",
                column: "CriancaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Crianca_CriancaId",
                table: "Usuario",
                column: "CriancaId",
                principalTable: "Crianca",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Crianca_CriancaId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CriancaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "CriancaId",
                table: "Usuario");
        }
    }
}
