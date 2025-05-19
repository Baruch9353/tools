using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1905
{
    internal class Hammer :Tool
    {
        public override string Name { get; set; }
        public override string Weight { get; set; }

        public override void Describe()
        {
            Console.WriteLine("Hammer is a handheld tool with a heavy metal head used for impact force.");
            
        }
        public override void Use()
        {
            Console.WriteLine( "Hammer Used for driving nails, breaking objects, and assembling materials");
        }
    }
}
