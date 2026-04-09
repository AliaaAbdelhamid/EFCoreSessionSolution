namespace SessionDemo.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public ICollection<BookPublishers> BookPublishers { get; set; } = new HashSet<BookPublishers>();
    }
}
