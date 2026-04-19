using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddBookWithCategoryAndAuthorView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create View BookWithCatAndAuthor 
As 
   Select B.Title [BookTitle] , A.FullName [AuthorName] , B.BookCategory 
   From Library.Books B, Library.Books_Authors BA , Library.Authors A
   where B.ISBN = BA.BookISBN and A.Id = BA.AuthorId");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Drop View BookWithCatAndAuthor");
        }
    }
}
