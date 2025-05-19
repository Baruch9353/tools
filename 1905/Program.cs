using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1905
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Hammer hammerition = new Hammer();
            Drill drill = new Drill();
            Saw saw = new Saw();
            Tool[] tools= new Tool[] {hammer, hammerition ,drill, saw};
            foreach (var tool in tools)
            {
                tool.Describe();
                tool.Use();
                
            }

        }
    }
}
