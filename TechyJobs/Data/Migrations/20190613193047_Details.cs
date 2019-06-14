using Microsoft.EntityFrameworkCore.Migrations;

namespace TechyJobs.Data.Migrations
{
    public partial class Details : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecruiterDetails",
                table: "Recruiter",
                newName: "Details");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Recruiter",
                newName: "RecruiterDetails");
        }
    }
}
