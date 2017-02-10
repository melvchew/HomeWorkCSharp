using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class Day3Quiz
    {
        public static void Main()
        {
            /* Write a program to convert length measurement from centimetre to inch. The measurement in inch can be calculated using the following formula:
             * length in inch = length in cm / 2.54
             */

            Console.WriteLine("This is a calculator to convert cm to inches");
            Console.WriteLine("Please key in the value in cm");
            double cm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:0.000}", Math.Round(cm/2.54,3));

        }
    }
}
