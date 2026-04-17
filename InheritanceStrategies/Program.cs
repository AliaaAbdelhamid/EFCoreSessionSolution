namespace InheritanceStrategies
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using MyCompanyDbContext dbContext = new();

            #region TPH 

            //Employee employee = new() { Name = "Mohamed", Age = 30 };
            //PartTimeEmployee partTimeEmployee = new() { Name = "Sara", Age = 25, HourRate = 15, CountOfHours = 20 };
            //FullTimeEmployee fullTimeEmployee = new() { Name = "Ali", Age = 35, Salary = 50000, StartDate = DateTime.Now.AddYears(-5) };

            //dbContext.Add(employee);
            //dbContext.Add(fullTimeEmployee);
            //dbContext.Add(partTimeEmployee);
            //dbContext.SaveChanges();


            //var employees = dbContext.Employees.OfType<FullTimeEmployee>().ToList();

            //if (employees.Count != 0)
            //{
            //    foreach (var employee in employees)
            //        Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Age} - {employee.Salary} - {employee.StartDate}");


            //}


            //Console.WriteLine("============================================");
            //var fullTimeEmployees = dbContext.FullTimeEmployees.ToList();
            //if (fullTimeEmployees.Count != 0)
            //{
            //    foreach (var employee in fullTimeEmployees)
            //        Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Age} - {employee.Salary} - {employee.StartDate}");
            //}




            #endregion

            #region TPT

            //Employee employee = new() { Name = "Mohamed", Age = 30 };
            //PartTimeEmployee partTimeEmployee = new() { Name = "Sara", Age = 25, HourRate = 15, CountOfHours = 20 };
            //FullTimeEmployee fullTimeEmployee = new() { Name = "Ali", Age = 35, Salary = 50000, StartDate = DateTime.Now.AddYears(-5) };

            //dbContext.Add(employee);
            //dbContext.Add(fullTimeEmployee);
            //dbContext.Add(partTimeEmployee);
            //dbContext.SaveChanges();



            //var employees = dbContext.Employees.ToList();

            //if (employees.Count != 0)
            //{
            //    foreach (var employee in employees)
            //        Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Age} ");

            //}


            //Console.WriteLine("============================================");
            //var fullTimeEmployees = dbContext.FullTimeEmployees.ToList();
            //if (fullTimeEmployees.Count != 0)
            //{
            //    foreach (var employee in fullTimeEmployees)
            //        Console.WriteLine($"{employee.Id} - {employee.Name} - {employee.Age} - {employee.Salary} - {employee.StartDate}");
            //}

            #endregion

            #region TPCT

            ////PartTimeEmployee partTimeEmployee = new() { Name = "Sara", Age = 25, HourRate = 15, CountOfHours = 20 };
            //FullTimeEmployee fullTimeEmployee = new() { Name = "Ali", Age = 35, Salary = 50000, StartDate = DateTime.Now.AddYears(-5) };

            //dbContext.Add(fullTimeEmployee);
            ////dbContext.Add(partTimeEmployee);
            //dbContext.SaveChanges();


            #endregion
        }
    }
}
