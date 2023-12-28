using Microsoft.EntityFrameworkCore.Migrations;

namespace Sprout.Exam.WebApp.Migrations
{
    public partial class updateEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Employees",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "Fullname");
        }
    }
}
