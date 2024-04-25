using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_GENIUS.Migrations
{
    /// <inheritdoc />
    public partial class CREATE_RELACIONAMENTO_1_1_AUTOR_E_1_N_EDITORA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorId",
                table: "BGENIUS_LIVRO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EditoraId",
                table: "BGENIUS_LIVRO",
                type: "NUMBER(10)",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BGENIUS_LIVRO_AutorId",
                table: "BGENIUS_LIVRO",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_BGENIUS_LIVRO_EditoraId",
                table: "BGENIUS_LIVRO",
                column: "EditoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_BGENIUS_LIVRO_BGENIUS_AUTOR_AutorId",
                table: "BGENIUS_LIVRO",
                column: "AutorId",
                principalTable: "BGENIUS_AUTOR",
                principalColumn: "AutorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BGENIUS_LIVRO_BGENIUS_EDITORA_EditoraId",
                table: "BGENIUS_LIVRO",
                column: "EditoraId",
                principalTable: "BGENIUS_EDITORA",
                principalColumn: "EditoraId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BGENIUS_LIVRO_BGENIUS_AUTOR_AutorId",
                table: "BGENIUS_LIVRO");

            migrationBuilder.DropForeignKey(
                name: "FK_BGENIUS_LIVRO_BGENIUS_EDITORA_EditoraId",
                table: "BGENIUS_LIVRO");

            migrationBuilder.DropIndex(
                name: "IX_BGENIUS_LIVRO_AutorId",
                table: "BGENIUS_LIVRO");

            migrationBuilder.DropIndex(
                name: "IX_BGENIUS_LIVRO_EditoraId",
                table: "BGENIUS_LIVRO");

            migrationBuilder.DropColumn(
                name: "AutorId",
                table: "BGENIUS_LIVRO");

            migrationBuilder.DropColumn(
                name: "EditoraId",
                table: "BGENIUS_LIVRO");
        }
    }
}
