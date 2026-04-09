namespace SessionDemo.Models
{
    public class Category
    {
        public int CategoryId { get; set; }         // Convention: Primary Key
        public string Name { get; set; } = string.Empty;  // Convention: nvarchar(max)
    }
}
