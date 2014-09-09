using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, social, hourly, worked;

            Console.Write("\n What is your name? "); name = Console.ReadLine();
            Console.Write(" What is your social security number? "); social = Console.ReadLine();
            Console.Write(" What is your hourly pay rate? "); hourly = Console.ReadLine();
            Console.Write(" How many hours have you worked? "); worked = Console.ReadLine();

            Double grosspay = Convert.ToDouble(hourly) * Convert.ToInt32(worked);

            Console.WriteLine("===================\nSUMMARY\n===================");
            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("SSN: {0}", social);
            Console.WriteLine("You've earned ${0} working at ${1} per hour.", Convert.ToDouble(hourly) * Convert.ToInt32(worked), hourly);
            Console.WriteLine("Gross pay:                    ${0}.", Convert.ToDouble(hourly) * Convert.ToInt32(worked));
            Console.WriteLine("Federal withholding:           ${0}", ((Convert.ToDouble(hourly) * Convert.ToInt32(worked)*0.15)));
            Console.WriteLine("State withholding:           ${0}", Convert.ToDouble(grosspay) * 0.05);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Net pay :                    ${0}", (Convert.ToDouble(hourly) * Convert.ToInt32(worked)) - (Convert.ToInt32((Convert.ToDouble(hourly) * Convert.ToInt32(worked) * 0.15)) + (Convert.ToDouble(hourly) * Convert.ToInt32(worked) * 0.15)));
        }
    }
}
