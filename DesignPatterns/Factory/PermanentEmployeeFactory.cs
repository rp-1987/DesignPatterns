using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class PermanentEmployeeFactory: BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp):base(emp)
        {

        }

        public override IEmployeeType Create()
        {
            PermanentEmployeeType permEmp = new PermanentEmployeeType();
            _emp.HRA = permEmp.GetHRA();
            return permEmp;
        }
    }
}
