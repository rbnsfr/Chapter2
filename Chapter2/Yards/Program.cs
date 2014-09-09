using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yards
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 25, width = 42, area = length * width;
            int Price = 10;
            double total = area * Price;

            Console.WriteLine("The cost of carpeting the room, which is {0}\nyards long and {1} yards wide, is ${2}.",length/3,width/3,total);
        }
    }
}
