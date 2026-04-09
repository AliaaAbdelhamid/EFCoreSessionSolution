namespace SessionDemo.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public Customer OrderCustomer { get; set; } = default!;

        public int CusId { get; set; }
    }
}
