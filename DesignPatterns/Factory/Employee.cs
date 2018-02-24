using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string EmployeeType { get; set; }
        public decimal Salary { get; set; }
        public decimal Bonus { get; set; }
    }
}
