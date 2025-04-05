using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "CarId",
                table: "Rentals",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                newName: "IX_Rentals_EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Employees_EmployeeId",
                table: "Rentals",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rentals_Employees_EmployeeId",
                table: "Rentals");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Rentals",
                newName: "CarId");

            migrationBuilder.RenameIndex(
                name: "IX_Rentals_EmployeeId",
                table: "Rentals",
                newName: "IX_Rentals_CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rentals_Cars_CarId",
                table: "Rentals",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
