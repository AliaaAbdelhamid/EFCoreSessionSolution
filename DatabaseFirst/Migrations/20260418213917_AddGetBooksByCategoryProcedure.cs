using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddGetBooksByCategoryProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create Procedure SP_GetBookByCategory @Category varchar(50)
As 
  Select *
  From Library.Books
  where BookCategory = @Category

  ");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop Procedure SP_GetBookByCategory ");
        }
    }
}
