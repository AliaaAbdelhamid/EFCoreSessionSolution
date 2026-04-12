namespace SessionDemo.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<CustomerService> ServiceCustomer { get; set; } = new HashSet<CustomerService>();
    }
}
