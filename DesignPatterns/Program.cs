using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Pattern Example
            //Parallel.Invoke(() => CreateStudent(), () => CreateEmployee());                        

            //Factory Pattern Example
            Employee e1 = new Employee { Id = 1, Name = "Aniket", Department = "IT", EmployeeType = "Permanent" };
            Employee e2 = new Employee { Id = 1, Name = "Aniket", Department = "IT", EmployeeType = "Contract" };
            EmployeeFactory factory = new EmployeeFactory();

            IEmployeeType empType = factory.GetEmployeeType(e1.EmployeeType);
            IEmployeeType empType2 = factory.GetEmployeeType(e2.EmployeeType);

            Console.WriteLine("Employee {0} has salary {1} and bonus {2}", e1.Name, empType.GetEmployeeSalary(), empType.GetEmployeeBonus());
            Console.WriteLine("Employee {0} has salary {1} and bonus {2}", e2.Name, empType2.GetEmployeeSalary(), empType2.GetEmployeeBonus());

            Console.ReadLine();
        }


        private static int GetEmployeeSalary(string employeeType)
        {
            if(employeeType == "Permanent")
            {
                return 10;
            }
            else if (employeeType == "Contract")
            {
                return 8;
            }
            return 0;
        }

        private static int GetEmployeeBonus(string employeeType)
        {
            if (employeeType == "Permanent")
            {
                return 5;
            }
            else if (employeeType == "Contract")
            {
                return 0;
            }
            return 0;
        }

        private static void CreateEmployee()
        {           
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
        }

        private static void CreateStudent()
        {
            System.Threading.Thread.Sleep(2000);
            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }


    }
}
