using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class PermanentEmployeeType : IEmployeeType
    {
        public int GetEmployeeBonus()
        {
            return 5;
        }

        public int GetEmployeeSalary()
        {
            return 10;
        }

        public int GetHRA()
        {
            return 5;
        }
    }
}
