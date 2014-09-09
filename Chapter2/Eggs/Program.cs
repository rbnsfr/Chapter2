using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int chicken1 = 6; int chicken2 = 3; int chicken3 = 14; int chicken4 = 2;
            int chickentotal = chicken1 + chicken2 + chicken3 + chicken4;

            Console.WriteLine("The total amount of eggs is {0} dozens and {1} leftover.", chickentotal/12, chickentotal%12);
        }
    }
}
