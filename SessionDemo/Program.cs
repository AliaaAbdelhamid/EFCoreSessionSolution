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

            #region Problem 
            //var order = dbContext.Orders.FirstOrDefault(x => x.Id == 1);

            //if (order != null)
            //{
            //    Console.WriteLine($"Order Id : {order.Id}"); // 1
            //    Console.WriteLine($"Order Number : {order.Number}"); // 1
            //    Console.WriteLine($"Order Customer Id : {order.CusId}"); // 1
            //    Console.WriteLine($"Order Customer Id : {order.OrderCustomer.Id}"); // Exception
            //    Console.WriteLine($"Order Customer Name : {order.OrderCustomer.Name}"); // Exception
            //}
            #endregion

            #region Solutions

            #region Eager Loading 

            #region Include()
            ////var order = dbContext.Orders.Include(x => x.OrderCustomer).FirstOrDefault(x => x.Id == 1);
            ////if (order != null)
            ////{
            ////    Console.WriteLine($"Order Id : {order.Id}"); // 1
            ////    Console.WriteLine($"Order Number : {order.Number}"); // 1
            ////    Console.WriteLine($"Order Customer Id : {order.CusId}"); // 1
            ////    Console.WriteLine($"Order Customer Id : {order.OrderCustomer.Id}"); // 1
            ////    Console.WriteLine($"Order Customer Name : {order.OrderCustomer.Name}"); // Ahmed Mohamed
            ////}


            //var customer = dbContext.Customers.Include(x => x.Orders).Include(x => x.CustomerServices).FirstOrDefault(x => x.Id == 1);
            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}"); // Ahmed Mohamed
            //    Console.WriteLine($"Customer Orders Count : {customer.Orders.Count}"); // 2
            //    Console.WriteLine($"Customer Services Count : {customer.CustomerServices.Count}"); // 2
            //} 
            #endregion

            #region ThenInclude()

            //var customer = dbContext.Customers.Include(x => x.CustomerServices).ThenInclude(cs => cs.Service).FirstOrDefault(x => x.Id == 1);
            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}"); // Ahmed Mohamed
            //    Console.WriteLine($"Customer Services Count : {customer.CustomerServices.Count}"); // 2
            //    foreach (var customerService in customer.CustomerServices)
            //    {
            //        Console.WriteLine($"Service Name : {customerService.Service.Name}"); // Service 01 , Service 02
            //    }
            //}
            #endregion

            #region Filtered Include 
            //var customer = dbContext.Customers.Include(x => x.CustomerServices.Where(x => x.Cost <= 10)).ThenInclude(cs => cs.Service).FirstOrDefault(x => x.Id == 1);
            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}"); // Ahmed Mohamed
            //    Console.WriteLine($"Customer Services Count : {customer.CustomerServices.Count}"); // 1
            //    foreach (var customerService in customer.CustomerServices)
            //    {
            //        Console.WriteLine($"Service Name : {customerService.Service.Name}"); // Service 01 
            //    }
            //}
            #endregion

            #region AsSplitQuery()
            //var customer = dbContext.Customers.Include(x => x.CustomerServices.Where(x => x.Cost <= 10))
            //                                 .ThenInclude(cs => cs.Service)
            //                                 .Include(x => x.Orders)
            //                                 .AsSplitQuery()
            //                                 .FirstOrDefault(x => x.Id == 1);
            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}"); // Ahmed Mohamed
            //    Console.WriteLine($"Customer Services Count : {customer.CustomerServices.Count}"); // 1
            //    foreach (var customerService in customer.CustomerServices)
            //    {
            //        Console.WriteLine($"Service Name : {customerService.Service.Name}"); // Service 01 
            //    }
            //}
            #endregion

            #endregion

            #region Explicit Loading

            #region Reference()
            //var order = dbContext.Orders.FirstOrDefault(x => x.Id == 1);

            //if (order != null)
            //{
            //    Console.WriteLine($"Order Customer Id   Before loading: {order.CusId}"); // 1
            //    Console.WriteLine($"Order Customer Id   Before loading: {order.OrderCustomer?.Id}"); // NULL
            //    Console.WriteLine($"Order Customer Name Before loading: {order.OrderCustomer?.Name}"); // NULL
            //    dbContext.Entry(order).Reference(o => o.OrderCustomer).Load();
            //    Console.WriteLine($"Order Customer Id   After loading: {order.CusId}"); // 1
            //    Console.WriteLine($"Order Customer Id   After loading: {order.OrderCustomer?.Id}"); // 1
            //    Console.WriteLine($"Order Customer Name After loading: {order.OrderCustomer?.Name}"); // Ahmed Mohamed
            //} 
            #endregion

            #region Collection()

            //var customer = dbContext.Customers.FirstOrDefault(x => x.Id == 1);

            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}"); // Ahmed Mohamed

            //    dbContext.Entry(customer).Collection(c => c.Orders).Load(); // Load Orders collection
            //    foreach (var order in customer.Orders) // Orders loaded after calling Load()
            //    {
            //        Console.WriteLine($"Order Number : {order.Number}");
            //    }


            //}

            #endregion

            #region Filtered Collection with Query()

            //var customer = dbContext.Customers.FirstOrDefault(x => x.Id == 1);

            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}"); // Ahmed Mohamed

            //    dbContext.Entry(customer).Collection(c => c.Orders).Query().Where(x => x.Number >= 2).Load();

            //    foreach (var order in customer.Orders) // Orders loaded after calling Load()
            //    {
            //        Console.WriteLine($"Order Number : {order.Number}");
            //    }
            //}

            #endregion

            #endregion

            #region Lazy Loading 

            //var order = dbContext.Orders.FirstOrDefault(x => x.Id == 1);

            //if (order != null)
            //{
            //    Console.WriteLine($"Order Number : {order.Number}"); // 1
            //    Console.WriteLine($"Order Customer Id : {order.CusId}"); // 1
            //    Console.WriteLine($"Order Customer Name : {order.OrderCustomer?.Name}"); // NULL
            //}


            //var customer = dbContext.Customers.FirstOrDefault(x => x.Id == 1);
            //if (customer != null)
            //{
            //    Console.WriteLine($"Customer Name : {customer.Name}"); // Ahmed Mohamed
            //    Console.WriteLine($"Customer Orders Count : {customer.Orders.Count}"); // 2
            //}


            #endregion

            #endregion
            #endregion

            #region Join LINQ Category

            #region Inner Join 

            //var result = from o in dbContext.Orders
            //             join c in dbContext.Customers
            //             on o.CusId equals c.Id
            //             select new
            //             {
            //                 CustomerName = c.Name,
            //                 OrderNumber = o.Number
            //             };


            //result = dbContext.Orders.Join(dbContext.Customers, o => o.CusId, c => c.Id, (o, c) => new
            //{
            //    CustomerName = c.Name,
            //    OrderNumber = o.Number
            //});

            //foreach (var item in result)
            //    Console.WriteLine(item);





            #endregion

            #region Group Join 

            #region Example 01
            //var result = dbContext.Customers.GroupJoin(dbContext.Orders, c => c.Id, o => o.CusId, (c, os) => new
            //{
            //    CustomerName = c.Name,
            //    Orders = os
            //}).Where(x => x.Orders.Count() > 2);


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer Name = {item.CustomerName}");
            //    foreach (var order in item.Orders)
            //    {
            //        Console.WriteLine($" Order #{order.Number}");
            //    }
            //}

            #endregion

            #region Example 02
            //var result = dbContext.Customers.GroupJoin(dbContext.Orders, c => c.Id, o => o.CusId, (c, o) => new
            //{
            //    CustomerName = c.Name,
            //    OrdersCount = o.Count()

            //});


            //foreach (var item in result)
            //    Console.WriteLine(item); 
            #endregion

            #region Query Syntax

            //var result = from c in dbContext.Customers
            //             join o in dbContext.Orders
            //             on c.Id equals o.CusId
            //             into Groups
            //             where Groups.Count() > 2
            //             select new
            //             {
            //                 CustomerName = c.Name,
            //                 Orders = Groups
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer Name = {item.CustomerName}");
            //    foreach (var order in item.Orders)
            //    {
            //        Console.WriteLine($" Order #{order.Number}");
            //    }
            //}

            #endregion

            #endregion

            #region Left Join 

            //var result = dbContext.Customers.LeftJoin(dbContext.Orders, c => c.Id, o => o.CusId, (c, o) => new
            //{
            //    CustomerName = c.Name,
            //    OrderNumber = o == null ? 0 : o.Number,
            //});


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #region Left Join Pre .Net 10

            //var result = dbContext.Customers.GroupJoin(dbContext.Orders, c => c.Id, o => o.CusId, (c, os) => new
            //{
            //    CustomerName = c.Name,
            //    Orders = os
            //}).SelectMany(x => x.Orders.DefaultIfEmpty(), (x, o) => new
            //{
            //    CustomerName = x.CustomerName,
            //    OrderNumber = o == null ? 0 : o.Number,
            //});


            //result = from c in dbContext.Customers
            //         join o in dbContext.Orders
            //         on c.Id equals o.Id
            //         into OrderGroups
            //         from o in OrderGroups.DefaultIfEmpty()
            //         select new
            //         {
            //             CustomerName = c.Name,
            //             OrderNumber = o == null ? 0 : o.Number,
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion




            #endregion

            #region Cross Join 

            //var result = dbContext.Customers.SelectMany(c => dbContext.Orders, (c, o) => new { c.Name, o.Number });

            //result = from c in dbContext.Customers
            //         from o in dbContext.Orders
            //         select new
            //         {
            //             c.Name,
            //             o.Number
            //         };
            //foreach (var item in result)
            //    Console.WriteLine(item);

            #endregion

            #endregion
        }
    }
}
