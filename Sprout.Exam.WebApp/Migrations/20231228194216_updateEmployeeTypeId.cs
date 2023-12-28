using Microsoft.EntityFrameworkCore.Migrations;

namespace Sprout.Exam.WebApp.Migrations
{
    public partial class updateEmployeeTypeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TIN",
                table: "Employees",
                newName: "Tin");

            migrationBuilder.RenameColumn(
                name: "EmployeeTypeId",
                table: "Employees",
                newName: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tin",
                table: "Employees",
                newName: "TIN");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Employees",
                newName: "EmployeeTypeId");
        }
    }
}
