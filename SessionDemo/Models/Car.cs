namespace SessionDemo.Models
{
    internal class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; } = null!;
        public EmployeeCar? EmployeeCar { get; set; }
    }
}
