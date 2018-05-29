using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRegister.Models
{
    public class SearchViewModel
    {
        public String SortFirstName { get; set; }
        public String SortLastName { get; set; }
        public int SortOrd { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}