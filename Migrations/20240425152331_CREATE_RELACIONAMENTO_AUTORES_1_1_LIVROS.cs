using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_GENIUS.Migrations
{
    /// <inheritdoc />
    public partial class CREATE_RELACIONAMENTO_AUTORES_1_1_LIVROS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BGENIUS_LIVRO_AutorId",
                table: "BGENIUS_LIVRO");

            migrationBuilder.CreateIndex(
                name: "IX_BGENIUS_LIVRO_AutorId",
                table: "BGENIUS_LIVRO",
                column: "AutorId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BGENIUS_LIVRO_AutorId",
                table: "BGENIUS_LIVRO");

            migrationBuilder.CreateIndex(
                name: "IX_BGENIUS_LIVRO_AutorId",
                table: "BGENIUS_LIVRO",
                column: "AutorId");
        }
    }
}
