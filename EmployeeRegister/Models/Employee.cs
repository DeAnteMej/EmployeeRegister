using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeRegister.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public String FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public String LastName { get; set; }

        [Range(1, Int32.MaxValue, ErrorMessage = "The Salary must be higher than 1 SEK")]
        public int Salary { get; set; }

        public string Position { get; set; }
        public string Department { get; set; }
    }
}