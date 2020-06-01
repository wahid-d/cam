using Microsoft.EntityFrameworkCore.Migrations;

namespace cam.Migrations
{
    public partial class RoomUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_AspNetUsers_SupervisorId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_SupervisorId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SupervisorId",
                table: "Rooms");

            migrationBuilder.AddColumn<string>(
                name: "SupervisorUserName",
                table: "Rooms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SupervisorUserName",
                table: "Rooms");

            migrationBuilder.AddColumn<string>(
                name: "SupervisorId",
                table: "Rooms",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_SupervisorId",
                table: "Rooms",
                column: "SupervisorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_AspNetUsers_SupervisorId",
                table: "Rooms",
                column: "SupervisorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
