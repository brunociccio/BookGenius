using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BOOK_GENIUS.Migrations
{
    /// <inheritdoc />
    public partial class CREATE_AUTORES : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BGENIUS_AUTORES",
                columns: table => new
                {
                    AutorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Biografia = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BGENIUS_AUTORES", x => x.AutorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BGENIUS_AUTORES");
        }
    }
}
