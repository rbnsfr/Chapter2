using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 30, width = 45;
            double cost = Convert.ToDouble(length * width);

            Console.WriteLine("Carpeting the room, which is {0} feet long and {1} feet wide, will cost ${2}.",length,width,cost);
        }
    }
}
