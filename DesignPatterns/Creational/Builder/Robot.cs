using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class Robot: IRobotPlan
    {
        public string Head { get; set; }
        public string Torso { get; set; }
        public string Legs { get; set; }
        public string Arms { get; set; }
    }
}
