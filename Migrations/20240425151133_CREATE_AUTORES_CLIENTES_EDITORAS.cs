using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_GENIUS.Migrations
{
    /// <inheritdoc />
    public partial class CREATE_AUTORES_CLIENTES_EDITORAS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BGENIUS_AUTORES",
                table: "BGENIUS_AUTORES");

            migrationBuilder.RenameTable(
                name: "BGENIUS_AUTORES",
                newName: "BGENIUS_AUTOR");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BGENIUS_AUTOR",
                table: "BGENIUS_AUTOR",
                column: "AutorId");

            migrationBuilder.CreateTable(
                name: "BGENIUS_CLIENTE",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGENIUS_CLIENTE", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "BGENIUS_EDITORA",
                columns: table => new
                {
                    EditoraId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Pais = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGENIUS_EDITORA", x => x.EditoraId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BGENIUS_CLIENTE");

            migrationBuilder.DropTable(
                name: "BGENIUS_EDITORA");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BGENIUS_AUTOR",
                table: "BGENIUS_AUTOR");

            migrationBuilder.RenameTable(
                name: "BGENIUS_AUTOR",
                newName: "BGENIUS_AUTORES");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BGENIUS_AUTORES",
                table: "BGENIUS_AUTORES",
                column: "AutorId");
        }
    }
}
