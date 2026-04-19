using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models
{
    public partial class CityLibraryDbContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookWithCategoryAndAuthorView>().HasNoKey().ToView("BookWithCatAndAuthor");
        }
    }
}
