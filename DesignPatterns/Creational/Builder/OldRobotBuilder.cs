using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class OldRobotBuilder : IRobotBuilder
    {

        private Robot robot;

        public OldRobotBuilder()
        {
            robot = new Robot();
        }

        public Robot MakeRobot()
        {
            return robot;
        }

        public void setArms()
        {
            robot.Arms = "Old Arms";
        }

        public void setHead()
        {
            robot.Head = "Old Head";
        }

        public void setLegs()
        {
            robot.Legs = "Old Legs";
        }

        public void setTorso()
        {
            robot.Torso = "Old Torso";
        }
    }
}
