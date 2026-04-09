using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SessionDemo.Migrations
{
    /// <inheritdoc />
    public partial class CustomerOrderRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CusId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CusId",
                table: "Orders",
                column: "CusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CusId",
                table: "Orders",
                column: "CusId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CusId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CusId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CusId",
                table: "Orders");
        }
    }
}
