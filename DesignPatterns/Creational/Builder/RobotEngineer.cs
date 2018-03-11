using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class RobotEngineer
    {
        private IRobotBuilder robotBuilder;

        public RobotEngineer(IRobotBuilder _robotBuilder)
        {
            robotBuilder = _robotBuilder;
        }

        public void MakeRobot()
        {
            this.robotBuilder.MakeRobot();
        }

        public Robot GetRobot()
        {
            robotBuilder.setArms();
            robotBuilder.setHead();
            robotBuilder.setLegs();
            robotBuilder.setTorso();
            return robotBuilder.MakeRobot();
        }
    }
}
