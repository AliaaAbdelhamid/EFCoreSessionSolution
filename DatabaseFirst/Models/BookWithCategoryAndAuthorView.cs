namespace DatabaseFirst.Models
{
    internal class BookWithCategoryAndAuthorView
    {
        public string BookTitle { get; set; } = default!;
        public string AuthorName { get; set; } = default!;
        public string BookCategory { get; set; } = default!;
    }
}
