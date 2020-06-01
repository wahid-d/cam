using Microsoft.EntityFrameworkCore.Migrations;

namespace cam.Migrations
{
    public partial class BooksAddedToClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CourseBook",
                table: "Classes",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GrammarBook",
                table: "Classes",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseBook",
                table: "Classes");

            migrationBuilder.DropColumn(
                name: "GrammarBook",
                table: "Classes");
        }
    }
}
