using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatetest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartamentoId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "DepartamentoId",
                table: "Employee",
                newName: "DepartamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartamentoId",
                table: "Employee",
                newName: "IX_Employee_DepartamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartamentId",
                table: "Employee",
                column: "DepartamentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartamentId",
                table: "Employee");

            migrationBuilder.RenameColumn(
                name: "DepartamentId",
                table: "Employee",
                newName: "DepartamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_DepartamentId",
                table: "Employee",
                newName: "IX_Employee_DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartamentoId",
                table: "Employee",
                column: "DepartamentoId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
