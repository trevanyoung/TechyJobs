using Microsoft.EntityFrameworkCore.Migrations;

namespace TechyJobs.Data.Migrations
{
    public partial class AddingUserIdToJobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Job",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Job");
        }
    }
}
