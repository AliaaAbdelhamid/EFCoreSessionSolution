using System.ComponentModel.DataAnnotations;

namespace SessionDemo.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public required decimal Salary { get; set; }
        // [Required] -> Validation attribute that indicates that the property is required and cannot be null at runtime [Mapped To Database]
        // required -> C# 11 feature that indicates that the property is required and cannot be null at compile time [Not Mapped To Database]
        public required string? Address { get; set; }
        // this still allows NULL in DB and NULL at runtime but it will give a compile-time error if you try to create an Employee without setting the Address property

        public EmployeeCar? EmployeeCar { get; set; }
        public int? ManagerId { get; set; } // nullable FK to parent (manager)
        public Employee? Manager { get; set; }

        public Address HomeAddress { get; set; }
    }


}
