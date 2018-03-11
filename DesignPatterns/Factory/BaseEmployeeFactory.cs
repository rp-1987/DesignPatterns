using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        public Employee ApplySalary()
        {
            IEmployeeType type = this.Create();
            _emp.Salary = type.GetEmployeeSalary();
            _emp.Bonus = type.GetEmployeeBonus();
            return _emp;
        }

        public abstract IEmployeeType Create();
    }
}
