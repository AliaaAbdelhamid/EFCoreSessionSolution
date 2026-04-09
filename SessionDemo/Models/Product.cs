namespace SessionDemo.Models
{
    internal class Product
    {
        // Ef Core Conventions For Primary Key :
        // 1. Property named "Id" or "<ClassName>Id" (e.g., ProductId) is automatically recognized as the primary key.
        // 2. The primary key property is by default configured as an identity column (auto-incrementing) for integer types.
        // 3. Property type can be int ,long, Guid, string but int is the most common choice for primary keys 
        public int Id { get; set; } // Primary Key

        // Nullable Reference Type 
        // string? -> Mapped As nvarchar(max) NULL in SQL Server
        public string? Name { get; set; }
        // Value Type (Non-Nullable)
        // decimal(18,2) NOT NULL in SQL Server
        public decimal Price { get; set; }
        // Value Type (Non-Nullable)
        // int NOT NULL in SQL Server
        public int Stock { get; set; }
    }
}
