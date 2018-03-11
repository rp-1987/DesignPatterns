using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public interface IRobotPlan
    {
        string Head { get; set; }
        string Torso { get; set; }
        string Legs { get; set; }
        string Arms { get; set; }
    }
}
