using Microsoft.EntityFrameworkCore.Migrations;

namespace TechyJobs.Data.Migrations
{
    public partial class FixedTypoInRecruiters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detials",
                table: "Recruiter",
                newName: "Details");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Details",
                table: "Recruiter",
                newName: "Detials");
        }
    }
}
