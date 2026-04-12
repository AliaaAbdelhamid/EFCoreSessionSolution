namespace SessionDemo.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public ICollection<CustomerService> CustomerServices { get; set; } = new HashSet<CustomerService>();
        public Address ShippingAddress { get; set; }
    }
}
