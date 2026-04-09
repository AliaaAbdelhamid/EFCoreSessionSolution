namespace SessionDemo.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; }
        public decimal Salary { get; set; }
        public EmployeeCar? EmployeeCar { get; set; }
        public int? ManagerId { get; set; } // nullable FK to parent (manager)
        public Employee? Manager { get; set; }
    }


}
