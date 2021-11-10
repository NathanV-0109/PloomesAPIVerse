using Microsoft.EntityFrameworkCore.Migrations;

namespace MyVerse.Migrations
{
    public partial class Verse2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Verses",
                table: "Verses");

            migrationBuilder.AlterColumn<string>(
                name: "Book",
                table: "Verses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Verses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Verses",
                table: "Verses",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Verses",
                table: "Verses");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Verses");

            migrationBuilder.AlterColumn<string>(
                name: "Book",
                table: "Verses",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Verses",
                table: "Verses",
                column: "Book");
        }
    }
}
