using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tcc.Migrations
{
    /// <inheritdoc />
    public partial class MaisUma3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crianca_Usuario_UsuarioId",
                table: "Crianca");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuario_Crianca_CriancaId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Usuario_CriancaId",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Crianca_UsuarioId",
                table: "Crianca");

            migrationBuilder.DropColumn(
                name: "CriancaId",
                table: "Usuario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Crianca");

            migrationBuilder.CreateIndex(
                name: "IX_Crianca_IdUsuario",
                table: "Crianca",
                column: "IdUsuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Crianca_Usuario_IdUsuario",
                table: "Crianca",
                column: "IdUsuario",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Crianca_Usuario_IdUsuario",
                table: "Crianca");

            migrationBuilder.DropIndex(
                name: "IX_Crianca_IdUsuario",
                table: "Crianca");

            migrationBuilder.AddColumn<int>(
                name: "CriancaId",
                table: "Usuario",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Crianca",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_CriancaId",
                table: "Usuario",
                column: "CriancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Crianca_UsuarioId",
                table: "Crianca",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Crianca_Usuario_UsuarioId",
                table: "Crianca",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuario_Crianca_CriancaId",
                table: "Usuario",
                column: "CriancaId",
                principalTable: "Crianca",
                principalColumn: "Id");
        }
    }
}
