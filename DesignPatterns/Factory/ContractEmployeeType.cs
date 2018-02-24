using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ContractEmployeeType : IEmployeeType
    {
        public int GetEmployeeBonus()
        {
            return 0;
        }

        public int GetEmployeeSalary()
        {
            return 8;
        }
    }
}
