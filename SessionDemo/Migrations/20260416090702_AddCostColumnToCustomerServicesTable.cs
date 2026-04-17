using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SessionDemo.Migrations
{
    /// <inheritdoc />
    public partial class AddCostColumnToCustomerServicesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cost",
                table: "CustomerService",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CustomerService",
                keyColumns: new[] { "CustomerId", "ServiceId" },
                keyValues: new object[] { 1, 1 },
                column: "Cost",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomerService",
                keyColumns: new[] { "CustomerId", "ServiceId" },
                keyValues: new object[] { 1, 2 },
                column: "Cost",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomerService",
                keyColumns: new[] { "CustomerId", "ServiceId" },
                keyValues: new object[] { 2, 2 },
                column: "Cost",
                value: null);

            migrationBuilder.UpdateData(
                table: "CustomerService",
                keyColumns: new[] { "CustomerId", "ServiceId" },
                keyValues: new object[] { 3, 3 },
                column: "Cost",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cost",
                table: "CustomerService");
        }
    }
}
