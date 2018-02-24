using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class EmployeeFactory
    {
        public IEmployeeType GetEmployeeType(string employeeType)
        {
            if(employeeType == "Permanent")
            {
                return new PermanentEmployeeType();
            }
            else
            {
                return new ContractEmployeeType();
            }
        }
    }
}
