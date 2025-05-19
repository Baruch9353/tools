using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1905
{
    internal class Drill : Tool
    {
        public override string Name { get; set; }
        public override string Weight { get; set; }

        public override void Describe()
        {
            Console.WriteLine("Drill is a powered tool with a rotating bit designed for making precise holes.");

        }
        public override void Use()
        {
            Console.WriteLine( "Drill Used for drilling holes in wood, metal, and concrete, and for inserting screws and anchors");
        }
    }
}
