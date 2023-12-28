using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprout.Exam.WebApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public DateTime Birthdate { get; set; }
        public string Fullname { get; set; }
        public string TIN { get; set; }
        public int EmployeeTypeId { get; set; }
    }
}
