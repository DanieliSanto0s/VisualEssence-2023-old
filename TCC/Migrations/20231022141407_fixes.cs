using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tcc.Migrations
{
    /// <inheritdoc />
    public partial class fixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogada_Crianca_CriancaId",
                table: "Jogada");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogada_Jogo_JogoId",
                table: "Jogada");

            migrationBuilder.DropIndex(
                name: "IX_Jogada_CriancaId",
                table: "Jogada");

            migrationBuilder.DropIndex(
                name: "IX_Jogada_JogoId",
                table: "Jogada");

            migrationBuilder.DropColumn(
                name: "CriancaId",
                table: "Jogada");

            migrationBuilder.DropColumn(
                name: "JogoId",
                table: "Jogada");

            migrationBuilder.CreateIndex(
                name: "IX_Jogada_IdCrianca",
                table: "Jogada",
                column: "IdCrianca");

            migrationBuilder.CreateIndex(
                name: "IX_Jogada_IdJogo",
                table: "Jogada",
                column: "IdJogo");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogada_Crianca_IdCrianca",
                table: "Jogada",
                column: "IdCrianca",
                principalTable: "Crianca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogada_Jogo_IdJogo",
                table: "Jogada",
                column: "IdJogo",
                principalTable: "Jogo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogada_Crianca_IdCrianca",
                table: "Jogada");

            migrationBuilder.DropForeignKey(
                name: "FK_Jogada_Jogo_IdJogo",
                table: "Jogada");

            migrationBuilder.DropIndex(
                name: "IX_Jogada_IdCrianca",
                table: "Jogada");

            migrationBuilder.DropIndex(
                name: "IX_Jogada_IdJogo",
                table: "Jogada");

            migrationBuilder.AddColumn<int>(
                name: "CriancaId",
                table: "Jogada",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JogoId",
                table: "Jogada",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jogada_CriancaId",
                table: "Jogada",
                column: "CriancaId");

            migrationBuilder.CreateIndex(
                name: "IX_Jogada_JogoId",
                table: "Jogada",
                column: "JogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogada_Crianca_CriancaId",
                table: "Jogada",
                column: "CriancaId",
                principalTable: "Crianca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jogada_Jogo_JogoId",
                table: "Jogada",
                column: "JogoId",
                principalTable: "Jogo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
