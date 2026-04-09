using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SessionDemo.Models
{
    [Table("Students", Schema = "edu")]// Custom table name + schema
    public class Student
    {
        [Key]// Explicit primary key (redundant here by convention but shown for clarity)
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  // Auto-increment
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]// NOT NULL in database
        [MaxLength(100)]// nvarchar(100)
        [Column("StdFirstName")]// Map to a different column name
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required")]// NOT NULL in database
        [MaxLength(100)]// nvarchar(100)            
        public string LastName { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Invalid email address")]// Validation hint (not enforced by EF, but useful with validators)
        [MaxLength(200)]
        public string? Email { get; set; }

        [Range(16, 100, ErrorMessage = "Age must be between 16 and 100")] // Validation hint
        public int Age { get; set; }

        [NotMapped]// This property is IGNORED by EF Core — no column created
        public string FullName => $"{FirstName} {LastName}";
    }
}
