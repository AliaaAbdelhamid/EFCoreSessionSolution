namespace SessionDemo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public virtual Customer OrderCustomer { get; set; } = default!;

        public int CusId { get; set; }
    }
}
