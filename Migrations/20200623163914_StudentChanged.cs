using Microsoft.EntityFrameworkCore.Migrations;

namespace cam.Migrations
{
    public partial class StudentChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "KoreanName",
                table: "Students",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "EnglishName",
                table: "Students",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "ParentPhone",
                table: "Students",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SelfPhone",
                table: "Students",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentPhone",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SelfPhone",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "KoreanName",
                table: "Students",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EnglishName",
                table: "Students",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Students",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }
    }
}
