using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SessionDemo.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeAddressColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress_Street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeAddress_City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Country",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "HomeAddress_Street",
                table: "Employees");
        }
    }
}
