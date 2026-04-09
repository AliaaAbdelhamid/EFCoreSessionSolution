namespace SessionDemo.Models
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public ICollection<CustomerService> CustomerServices { get; set; } = new HashSet<CustomerService>();
    }
}
