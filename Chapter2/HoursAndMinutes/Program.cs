using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoursAndMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = 204;

            Console.WriteLine("You have been working for {0} hours and {1} minutes.", minutes / 60, minutes % 60);
        }
    }
}
