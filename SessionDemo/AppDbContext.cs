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
            //optionsBuilder.LogTo(Console.WriteLine);
            //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Student> StudentsTable { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<Employee> Employees { get; set; }
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

            #region Shadow Properties

            modelBuilder.Entity<Customer>(EB =>
                      {
                          EB.Property<DateTime>("CreatedAt");
                          EB.Property<DateTime>("UpdatedAt");
                          EB.Property<string>("LastModifiedBy");
                      });

            #endregion

            #region Owned Entity Types


            modelBuilder.Entity<Customer>(EB =>
            {
                EB.OwnsOne(c => c.ShippingAddress, a =>
                {
                    a.Property(x => x.Street).HasColumnName("ShippingStreet");
                    a.Property(x => x.City).HasColumnName("ShippingCity");
                });

            });

            modelBuilder.Entity<Employee>(EB =>
            {
                EB.OwnsOne(e => e.HomeAddress);
            });

            #endregion

            #region Data Seeding

            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Service01" },
                new Service { Id = 2, Name = "Service02" },
                new Service { Id = 3, Name = "Service03" }
            );

            modelBuilder.Entity<CustomerService>().HasData(
                new CustomerService { CustomerId = 1, ServiceId = 1 },
                new CustomerService { CustomerId = 1, ServiceId = 2 },
                new CustomerService { CustomerId = 2, ServiceId = 2 },
                new CustomerService { CustomerId = 3, ServiceId = 3 }
            );
            #endregion
        }
    }
}
