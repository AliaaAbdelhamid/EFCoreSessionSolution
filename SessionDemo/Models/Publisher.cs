namespace SessionDemo.Models
{
    internal class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public BookPublishers? PublisherBook { get; set; }
    }
}
