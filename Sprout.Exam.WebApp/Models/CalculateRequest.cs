using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprout.Exam.WebApp.Models
{
    public class CalculateRequest
    {
        public double AbsentDays { get; set; }
        public double WorkedDays { get; set; }
    }
}
