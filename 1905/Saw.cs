using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1905
{
    internal class Saw : Tool
    
    {
        public override string Name { get; set; }
        public override string Weight { get; set; }

        public override int counter { get; set; }
        public override void Describe()
        {
            Console.WriteLine("Saw sharp blade, manual or powered, designed for cutting through materials.");

        }
        public override void Use()
        {
            UseCount();
            Console.WriteLine("Saw Used for cutting wood, metal, or plastic in construction and crafting projects. Use until now  " + counter);
        }

        public override void UseCount()
        {
            counter++;
            
        }
    }
}
