using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_GENIUS.Migrations
{
    /// <inheritdoc />
    public partial class CREATE_RELACIONAMENTO_EMPRESTIMO_1_N_LIVROS_1_N_CLIENTES : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BGENIUS_EMPRESTIMO_ClienteId",
                table: "BGENIUS_EMPRESTIMO",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_BGENIUS_EMPRESTIMO_LivroId",
                table: "BGENIUS_EMPRESTIMO",
                column: "LivroId");

            migrationBuilder.AddForeignKey(
                name: "FK_BGENIUS_EMPRESTIMO_BGENIUS_CLIENTE_ClienteId",
                table: "BGENIUS_EMPRESTIMO",
                column: "ClienteId",
                principalTable: "BGENIUS_CLIENTE",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BGENIUS_EMPRESTIMO_BGENIUS_LIVRO_LivroId",
                table: "BGENIUS_EMPRESTIMO",
                column: "LivroId",
                principalTable: "BGENIUS_LIVRO",
                principalColumn: "LivroId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BGENIUS_EMPRESTIMO_BGENIUS_CLIENTE_ClienteId",
                table: "BGENIUS_EMPRESTIMO");

            migrationBuilder.DropForeignKey(
                name: "FK_BGENIUS_EMPRESTIMO_BGENIUS_LIVRO_LivroId",
                table: "BGENIUS_EMPRESTIMO");

            migrationBuilder.DropIndex(
                name: "IX_BGENIUS_EMPRESTIMO_ClienteId",
                table: "BGENIUS_EMPRESTIMO");

            migrationBuilder.DropIndex(
                name: "IX_BGENIUS_EMPRESTIMO_LivroId",
                table: "BGENIUS_EMPRESTIMO");
        }
    }
}
