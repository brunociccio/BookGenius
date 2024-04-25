using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_GENIUS.Migrations
{
    /// <inheritdoc />
    public partial class CREATE_AUTORES_CLIENTES_EDITORAS_EMPRESTIMOS_LIVROS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BGENIUS_EMPRESTIMO",
                columns: table => new
                {
                    EmprestimoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DataEmprestimo = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DataDevolucao = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    LivroId = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ClienteId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGENIUS_EMPRESTIMO", x => x.EmprestimoId);
                });

            migrationBuilder.CreateTable(
                name: "BGENIUS_LIVRO",
                columns: table => new
                {
                    LivroId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Titulo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ISBN = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Paginas = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGENIUS_LIVRO", x => x.LivroId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BGENIUS_EMPRESTIMO");

            migrationBuilder.DropTable(
                name: "BGENIUS_LIVRO");
        }
    }
}
