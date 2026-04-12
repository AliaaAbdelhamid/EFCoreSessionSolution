namespace SessionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext dbContext = new();

            #region Shadow Properties

            //var customer = dbContext.Customers.FirstOrDefault();

            //// Setting the value of a shadow property

            //dbContext.Entry(customer!).Property("UpdatedAt").CurrentValue = DateTime.Now;

            //// Getting the value of a shadow property
            //var createdAt = dbContext.Entry(customer!).Property<DateTime>("CreatedAt").CurrentValue;

            #endregion

            #region CRUD Operations 

            #region Create 

            //var newEmployee = new Employee
            //{
            //    Name = "Salma Amr",
            //    Salary = 60000,
            //    Address = null,
            //    HomeAddress = new Address
            //    {
            //        Street = "123 Main St",
            //        City = "Cairo",
            //        Country = "Egypt"
            //    }
            //};

            #region Add
            //dbContext.Employees.Add(newEmployee);
            //dbContext.Set<Employee>().Add(newEmployee);
            //dbContext.Add(newEmployee);


            //dbContext.SaveChanges(); 
            #endregion

            #region Change Entity State To Add
            //Console.WriteLine($"State Before Adding = {dbContext.Entry(newEmployee).State}");
            //Console.WriteLine($"Employee Id = {newEmployee.Id}");
            //dbContext.Entry(newEmployee).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            //Console.WriteLine($"State After Adding = {dbContext.Entry(newEmployee).State}");
            //Console.WriteLine($"Employee Id After Adding = {newEmployee.Id}");
            //dbContext.SaveChanges();
            //Console.WriteLine($"State After SaveChanges = {dbContext.Entry(newEmployee).State}");
            //Console.WriteLine($"Employee Id SaveChanges = {newEmployee.Id}");

            #endregion
            #endregion

            #region Read

            //var employee01 = dbContext.Employees.AsNoTracking().FirstOrDefault(e => e.Id == 1);
            ////employee01 = dbContext.Employees.Find(1);
            //// SELECT TOP(1) * FROM[Employees] AS[e] WHERE[e].[Id] = 1
            //if (employee01 != null)
            //{
            //    Console.WriteLine($"State  = {dbContext.Entry(employee01).State}");
            //}





            #endregion

            #region Update
            //var employee01 = dbContext.Employees.FirstOrDefault(e => e.Id == 1);

            //if (employee01 != null)
            //{
            //    employee01.Salary = 70000;

            //    #region Update Methods
            //    //dbContext.Employees.Update(employee01);
            //    //dbContext.Set<Employee>().Update(employee01);
            //    //dbContext.Update(employee01);
            //    #endregion

            //    #region Change Entity State To Modified
            //    //Console.WriteLine($"State Before Updating = {dbContext.Entry(employee01).State}");
            //    //dbContext.Entry(employee01).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //    //Console.WriteLine($"State After Updating = {dbContext.Entry(employee01).State}");
            //    #endregion


            //    Console.WriteLine($"State Before Updating = {dbContext.Entry(employee01).State}");
            //    dbContext.Update(employee01);
            //    dbContext.SaveChanges();
            //    Console.WriteLine($"State After Updating = {dbContext.Entry(employee01).State}");
            //}

            #endregion

            #region Delete
            //var employee01 = dbContext.Employees.FirstOrDefault(e => e.Id == 1);

            //if (employee01 != null)
            //{
            //    Console.WriteLine($"Entity State Before Remove = {dbContext.Entry(employee01).State}");
            //    dbContext.Employees.Remove(employee01);
            //    Console.WriteLine($"Entity State After Remove = {dbContext.Entry(employee01).State}");
            //    dbContext.SaveChanges();
            //    Console.WriteLine($"Entity State After SaveChanges = {dbContext.Entry(employee01).State}");
            //}
            #endregion

            #region Bulk Operations

            ////var employees = dbContext.Employees.Where(e => e.Salary >= 5000).ToList();
            ////foreach (var employee in employees)
            ////{
            ////    employee.Salary *= 1.2m;
            ////}
            ////dbContext.SaveChanges();


            //dbContext.Employees.Where(e => e.Salary >= 5000)
            //    .ExecuteUpdate(e => e.SetProperty(emp => emp.Salary, emp => emp.Salary * 1.2m));
            #endregion

            #region Disconnected Scenario


            //var employee = dbContext.Employees.FirstOrDefault(x => x.Id == 2);

            //if (employee != null)
            //{
            //    employee.Salary = 60000;
            //    using AppDbContext newDbContext = new();

            //    #region Method 01 
            //    //Console.WriteLine(newDbContext.Entry(employee).State); // Detached
            //    //newDbContext.Update(employee);
            //    //Console.WriteLine(newDbContext.Entry(employee).State); // Modified
            //    //newDbContext.SaveChanges(); // Changes will be saved because the employee entity is now being tracked by the newDbContext instance.
            //    //Console.WriteLine(newDbContext.Entry(employee).State); // Unchanged 
            //    #endregion

            //    #region Method 02
            //    //Console.WriteLine(newDbContext.Entry(employee).State); // Detached
            //    //newDbContext.Attach(employee);
            //    //Console.WriteLine(newDbContext.Entry(employee).State); // Unchanged 
            //    //newDbContext.Entry(employee).Property(e => e.Salary).IsModified = true;
            //    //Console.WriteLine(newDbContext.Entry(employee).State); // Modified
            //    //newDbContext.SaveChanges();
            //    //Console.WriteLine(newDbContext.Entry(employee).State); // Unchanged 
            //    #endregion

            //} 
            #endregion

            #endregion

            #region Tracking vs No-Tracking

            //dbContext.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.NoTracking;
            //var employee01 = dbContext.Employees.FirstOrDefault(e => e.Id == 1); // not Tracked 

            //employee01.Salary = 70000;
            //dbContext.SaveChanges();  // No changes will be saved because the employee01 entity is not being tracked by the dbContext instance.

            //dbContext.ChangeTracker.QueryTrackingBehavior = Microsoft.EntityFrameworkCore.QueryTrackingBehavior.TrackAll;
            //employee01 = dbContext.Employees.FirstOrDefault(e => e.Id == 1); // Tracked
            //employee01.Salary = 70000;
            //dbContext.SaveChanges();  // Changes will be saved because the employee01 entity is now being tracked by the dbContext instance.

            #endregion

            #region Data Seeding 

            //if (!dbContext.Set<Customer>().Any())
            //{
            //    dbContext.Set<Customer>().AddRange(
            //        new Customer { Name = "Ahmed Mohamed" },
            //        new Customer { Name = "Salma Osama" },
            //        new Customer { Name = "Mariam Ahmed" }
            //    );

            //    //// Data From File
            //    //List<Customer> Customers = new()
            //    //{
            //    //    new Customer { Name = "Ahmed Mohamed" },
            //    //    new Customer { Name = "Salma Osama" },
            //    //    new Customer { Name = "Mariam Ahmed" }
            //    //};

            //    //dbContext.AddRange(Customers);

            //    dbContext.SaveChanges();

            //    Console.WriteLine("Customers Data Seeded");
            //}

            #endregion

            #region Loading Related Data 

            #region Select Data From Navigation Property
            //var order = dbContext.Orders.Select(o => new
            //{
            //    OrderId = o.Id,
            //    OrderNumber = o.Number,
            //    CustomerId = o.CusId,
            //    CustomerName = o.OrderCustomer.Name,

            //}).FirstOrDefault(o => o.OrderId == 1);
            //if (order != null)
            //{
            //    Console.WriteLine($"Order Number : {order.OrderNumber}"); // 1
            //    Console.WriteLine($"Order Customer Id : {order.CustomerId}"); // 1 
            //    Console.WriteLine($"Order Customer Name  : {order.CustomerName}"); // 1 
            //    //Console.WriteLine($"Order Customer Id : {order.OrderCustomer.Id}"); // null
            //    //Console.WriteLine($"Order Customer Name : {order.OrderCustomer.Name}"); // null 

            //} 
            #endregion

            #region Eager Loading 

            //var order = dbContext.Orders.Include(x => x.OrderCustomer).FirstOrDefault(o => o.Id == 1);

            //if (order != null)
            //{
            //    Console.WriteLine($"Order Number : {order.Number}"); // 1
            //    Console.WriteLine($"Order Customer Id : {order.CusId}"); // 1 
            //    Console.WriteLine($"Order Customer Name  : {order.OrderCustomer.Name}"); // Ahmed Mohamed
            //}


            //var customer = dbContext.Customers.Include(c => c.Orders).Include(c => c.CustomerServices).FirstOrDefault(c => c.Id == 1);

            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}");
            //    Console.WriteLine($"Number of Orders : {customer.Orders.Count}");
            //    Console.WriteLine($"Number of Customer Services : {customer.CustomerServices.Count}");
            //}


            //var customer = dbContext.Customers.Include(c => c.CustomerServices).ThenInclude(cs => cs.Service).FirstOrDefault(x => x.Id == 1);

            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}");
            //    foreach (var customerService in customer.CustomerServices)
            //    {
            //        Console.WriteLine($"Customer Service Name : {customerService.Service.Name}");
            //    }
            //}

            //var customer = dbContext.Customers.Include(c => c.CustomerServices.Where(x => x.Cost > 20)).ThenInclude(o => o.Service).FirstOrDefault(x => x.Id == 1);
            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}");
            //    foreach (var customerService in customer.CustomerServices)
            //    {
            //        Console.WriteLine($"Customer Service Name : {customerService.Service.Name}");
            //    }
            //}
            #endregion

            #region Explicit Loading 

            //var order = dbContext.Orders.FirstOrDefault(x => x.Id == 1);

            //if (order != null)
            //{
            //    Console.WriteLine($"Order Number : {order.Number}"); // 1
            //    Console.WriteLine($"Order Customer Id : {order.CusId}"); // 1 
            //    Console.WriteLine($"Order Customer Name Before Load  : {order.OrderCustomer?.Name}"); // null
            //    dbContext.Entry(order).Reference(o => o.OrderCustomer).Load();
            //    Console.WriteLine($"Order Customer Name After Load : {order.OrderCustomer?.Name}"); // Ahmed Mohamed
            //}


            //var customer = dbContext.Customers.FirstOrDefault(x => x.Id == 1);

            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}");

            //    dbContext.Entry(customer).Collection(c => c.Orders).Query().Where(x => x.Number >= 2).Load();
            //    foreach (var order in customer.Orders)
            //    {
            //        Console.WriteLine($"Order Number : {order.Number}");
            //    }
            //}

            #endregion

            #region Lazy Loading 

            //var order = dbContext.Orders.FirstOrDefault(x => x.Id == 1);

            //if (order != null)
            //{
            //    Console.WriteLine($"Order Number : {order.Number}"); // 1
            //    Console.WriteLine($"Order Customer Id : {order.CusId}"); // 1 
            //    Console.WriteLine($"Order Customer Name : {order.OrderCustomer?.Name}");
            //}


            //var customer = dbContext.Customers.FirstOrDefault(x => x.Id == 1);

            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}");

            //    foreach (var order in customer.Orders)
            //    {
            //        Console.WriteLine($"Order Number : {order.Number}");
            //    }
            //}
            #endregion

            #endregion
        }
    }
}
