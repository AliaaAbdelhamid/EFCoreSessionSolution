using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SessionDemo.Migrations
{
    /// <inheritdoc />
    public partial class CustomerAddressColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShippingAddress_Country",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingCity",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShippingStreet",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShippingAddress_Country",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShippingCity",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShippingStreet",
                table: "Customers");
        }
    }
}
