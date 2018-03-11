using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeType Create()
        {
            ContractEmployeeType contractEmployeeType = new ContractEmployeeType();
            _emp.MedicalAllowance = contractEmployeeType.GetMedicalAllowance();
            return contractEmployeeType;
        }
    }
}
