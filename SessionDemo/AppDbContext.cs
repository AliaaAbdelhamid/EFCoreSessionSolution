using Microsoft.EntityFrameworkCore;
using SessionDemo.Configurations;
using SessionDemo.Models;

namespace SessionDemo
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreGr;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> StudentsTable { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employees");

                entity.HasKey(i => i.Id);

                entity.Property(i => i.Name)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(i => i.Address)
                      .HasMaxLength(300);

                entity.Property(i => i.Salary)
                      .HasColumnType("decimal(10,2)");


            });


            modelBuilder.ApplyConfiguration<Course>(new CourseConfiguration());


            modelBuilder.Entity<Customer>()
                        .HasMany(C => C.Orders)
                        .WithOne(O => O.OrderCustomer)
                        .HasForeignKey(O => O.CusId);

            modelBuilder.Entity<CustomerService>()
                //.HasKey("ServiceId", "CustomerId");
                .HasKey(CS => new { CS.ServiceId, CS.CustomerId });

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Manager)
                .WithMany()
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.NoAction);    // Avoid cycles in SQL Server
        }
    }
}
