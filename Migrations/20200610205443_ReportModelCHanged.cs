using Microsoft.EntityFrameworkCore.Migrations;

namespace cam.Migrations
{
    public partial class ReportModelCHanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Attitude",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Homework",
                table: "Reports",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attitude",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Homework",
                table: "Reports");
        }
    }
}
