using InheritanceStrategies.Models;
using Microsoft.EntityFrameworkCore;

namespace InheritanceStrategies
{
    internal class MyCompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"Server=.;Database=MyCompanyDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region TPH
            //modelBuilder.Entity<Employee>()
            //    .HasDiscriminator<int>("EmployeeType")
            //    .HasValue<Employee>(0)
            //    .HasValue<FullTimeEmployee>(1)
            //    .HasValue<PartTimeEmployee>(2); 
            #endregion

            #region TPT

            //modelBuilder.Entity<FullTimeEmployee>().ToTable("FullTimeEmployees");
            //modelBuilder.Entity<PartTimeEmployee>().ToTable("PartTimeEmployees");

            #endregion

            #region TPCT
            //modelBuilder.HasSequence<int>("EmployeeSequence");
            //modelBuilder.Entity<FullTimeEmployee>()
            //            .Property(e => e.Id)
            //            .HasDefaultValueSql("next value for EmployeeSequence");

            //modelBuilder.Entity<PartTimeEmployee>()
            //           .Property(e => e.Id)
            //           .HasDefaultValueSql("next value for EmployeeSequence");

            modelBuilder.Entity<Employee>().UseTpcMappingStrategy();

            #endregion
        }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
    }
}
