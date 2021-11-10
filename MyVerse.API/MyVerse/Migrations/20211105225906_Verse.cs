using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVerse.Migrations
{
    public partial class Verse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Verses",
                columns: table => new
                {
                    Book = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Verse = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verses", x => x.Book);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Verses");
        }
    }
}
