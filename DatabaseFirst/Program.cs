using DatabaseFirst.Models;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CityLibraryDbContext dbContext = new();

            #region FromSqlRaw - FromSql
            //string publicationYear = "2010";
            //var result = dbContext.Books.FromSqlRaw($"Select * From Library.Books Where PublicationYear > {publicationYear}").ToList();
            //var result = dbContext.Books.FromSqlRaw("Select * From Library.Books Where PublicationYear > {0}", publicationYear).ToList();

            //var result = dbContext.Books.FromSql($"Select * From Library.Books Where PublicationYear > {publicationYear}").ToList();


            //var result = dbContext.Set<AuthorBooks>().FromSql($"Exec SP_Author_Books").ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.FullName);
            //} 
            #endregion

            #region ExecuteSql
            //       string name = "Mohamed";
            //       string nationality = "Egyptian";
            //       DateTime dateOfBirth = DateTime.Now.AddYears(-40);

            //       int rowsAffected = dbContext.Database.ExecuteSql(@$"INSERT INTO [Library].[Authors]
            //      ([FullName]
            //      ,[Nationality]
            //      ,[DateOfBirth])
            //VALUES
            //      ({name}
            //      ,{nationality}
            //      ,{dateOfBirth})");


            #endregion

            #region SqlQuery

            //var count = dbContext.Database.SqlQuery<int>($"Select Count(*) AS Value From Library.Books ").First();


            //var result = dbContext.Database.SqlQuery<BookInfo>($"Select ISBN , Title From Library.Books").ToList();

            //foreach (var item in result)
            //    Console.WriteLine(item);
            #endregion

            #region Stored Procedure 
            //string category = "Programming";
            //var result = dbContext.Books.FromSql($"Exec SP_GetBookByCategory {category}").ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Title);
            //}
            #endregion

            #region Views
            //var result = dbContext.Set<BookWithCategoryAndAuthorView>().Where(x => x.AuthorName == "Bjarne Stroustrup").ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.AuthorName} - {item.BookTitle} - {item.BookCategory}");
            //}
            #endregion
        }
    }

    public record BookInfo(string ISBN, string Title);
}
