using Microsoft.EntityFrameworkCore;

namespace SessionDemo.Models
{
    [PrimaryKey(nameof(ServiceId), nameof(CustomerId))]
    // EF Core 7.0 [.Net 6 and .Net 7]
    // while it was released alongside .net 7 
    // it maintains compatibility with .net 6 as well [Long-term support]
    // so developers can benefit from the new features without needing to upgrade their entire application to .net 7
    public class CustomerService
    {
        public Service Service { get; set; } = default!;
        public int ServiceId { get; set; } // FK to Service
        public Customer Customer { get; set; } = default!;
        public int CustomerId { get; set; } // FK to Customer
    }
}
