using System.ComponentModel.DataAnnotations;

namespace SessionDemo.Models
{
    internal class EmployeeCar
    {
        [Key]
        public int CarId { get; set; } // FK 
        public Car Car { get; set; } = default!;

        public int EmployeeId { get; set; } // FK
        public Employee Employee { get; set; } = default!;
    }
}
