using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartamentId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartamentId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartamentId",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartamentId",
                table: "Employee",
                column: "DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartamentId",
                table: "Employee",
                column: "DepartamentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
