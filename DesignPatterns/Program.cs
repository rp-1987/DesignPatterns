using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel.Invoke(() => CreateStudent(), () => CreateEmployee());                        
            Console.ReadLine();
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
