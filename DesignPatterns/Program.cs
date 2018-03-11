using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Factory;
using DesignPatterns.Creational.Builder;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Pattern Example
            //Parallel.Invoke(() => CreateStudent(), () => CreateEmployee());                        

            ////Factory Pattern Example
            //Employee e1 = new Employee { Id = 1, Name = "Aniket", Department = "IT", EmployeeType = "Permanent" };
            //Employee e2 = new Employee { Id = 1, Name = "Aniket", Department = "IT", EmployeeType = "Contract" };

            //BaseEmployeeFactory empFactory1 = new EmployeeFactory().CreateFactory(e1);
            //empFactory1.ApplySalary();
            //BaseEmployeeFactory empFactory2 = new EmployeeFactory().CreateFactory(e2);
            //empFactory2.ApplySalary();

            //Console.WriteLine("Employee {0} has salary {1} and bonus {2} and HRA {3}", e1.Name, e1.Salary, e1.Bonus, e1.HRA);
            //Console.WriteLine("Employee {0} has salary {1} and bonus {2} and Medical {3}", e2.Name, e2.Salary, e2.Bonus, e2.MedicalAllowance);

            //Console.ReadLine();

            IRobotBuilder robotBuilder = new OldRobotBuilder();
            RobotEngineer robotEngineer = new RobotEngineer(robotBuilder);
            robotEngineer.MakeRobot();
            Robot robot =  robotEngineer.GetRobot();
            Console.WriteLine("Robot has arms: {0}", robot.Arms);
            Console.ReadKey();
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
