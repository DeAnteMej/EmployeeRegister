namespace EmployeeRegister.Migrations
{
    using EmployeeRegister.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.DataAccesLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegister.DataAccesLayer.RegisterContext context)
        {
            context.Employees.AddOrUpdate(
                p => p.FirstName,
                new Employee { FirstName = "Anders", LastName = "Andersson", Salary = 35000, Position = "Big Boss", Department = "Export" },
                new Employee { FirstName = "Bertil", LastName = "Bertilsson", Salary = 32000, Position = "Small Boss", Department = "Export" },
                new Employee { FirstName = "Sune", LastName = "Sunesson", Salary = 33000, Position = "Boss", Department = "Ekonomics" },
                new Employee { FirstName = "Markus", LastName = "Sunesson", Salary = 39000, Position = "Boss", Department = "Sport" },
                new Employee { FirstName = "Lotta", LastName = "Sunesson", Salary = 33000, Position = "Skribent", Department = "Sport" },
                new Employee { FirstName = "Tomas", LastName = "Eriksson", Salary = 33000, Position = "Skribent", Department = "Ekonomics" }
                );
        }
    }
}
