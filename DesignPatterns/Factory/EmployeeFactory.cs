using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class EmployeeFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            if(emp.EmployeeType == "Permanent")
            {
                return new PermanentEmployeeFactory(emp);
            }
            else
            {
                return new ContractEmployeeFactory(emp);
            }
        }
    }
}
