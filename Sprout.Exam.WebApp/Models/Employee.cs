using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sprout.Exam.WebApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "date")]
        public DateTime Birthdate { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string TIN { get; set; }
        public int EmployeeTypeId { get; set; }
    }
}
