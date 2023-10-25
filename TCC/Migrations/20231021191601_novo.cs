using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tcc.Migrations
{
    /// <inheritdoc />
    public partial class novo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crianca_Usuario_UsuarioId1",
                table: "Crianca");

            migrationBuilder.RenameColumn(
                name: "UsuarioId1",
                table: "Crianca",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Crianca_UsuarioId1",
                table: "Crianca",
                newName: "IX_Crianca_UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crianca_Usuario_UsuarioId",
                table: "Crianca",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crianca_Usuario_UsuarioId",
                table: "Crianca");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Crianca",
                newName: "UsuarioId1");

            migrationBuilder.RenameIndex(
                name: "IX_Crianca_UsuarioId",
                table: "Crianca",
                newName: "IX_Crianca_UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Crianca_Usuario_UsuarioId1",
                table: "Crianca",
                column: "UsuarioId1",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
