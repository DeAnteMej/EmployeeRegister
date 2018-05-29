using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeRegister.DataAccesLayer
{
    public class RegisterContext : DbContext
    {
        public RegisterContext() : base("DefaultConnection") { }
        public DbSet<Models.Employee> Employees { get; set; }
    }
}