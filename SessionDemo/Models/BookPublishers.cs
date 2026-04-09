using System.ComponentModel.DataAnnotations;

namespace SessionDemo.Models
{
    internal class BookPublishers
    {
        public int BookId { get; set; } // FK to Book
        public Book Book { get; set; } = default!;
        [Key]
        public int PublisherId { get; set; } // FK to Publisher 
        public Publisher Publisher { get; set; } = default!;
    }
}
