using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionA
    {
        public static void Main()
        {
            //Q1
            Console.WriteLine("Q1");
            Console.WriteLine("Melvin Chew");
            Console.WriteLine("E0167329@u.nus.edu");

            //Q2
            Console.WriteLine("Q2");
            Console.WriteLine("What is your name?");
            string input2 = Console.ReadLine();
            Console.WriteLine("How is your day {0}?", input2);

            //Q3
            Console.WriteLine("Q3");
            Console.WriteLine("Please enter an integer from 0 to 99?");
            string input3 = Console.ReadLine();
            int output3 = Convert.ToInt32(input3);
            Console.WriteLine("The square of the user input value is {0}", output3 *output3 );

            //Q4
            Console.WriteLine("Q4");
            Console.WriteLine("Please enter a double from 0 to 99?");
            string input4 = Console.ReadLine();
            double output4 = Convert.ToDouble(input4);
            Console.WriteLine("The square of the user input value is {0}", output4 * output4);

            //Q5
            Console.WriteLine("Q5");
            Console.WriteLine("Please enter an integer from 0 to 999?");
            string input5 = Console.ReadLine();
            double output5 = Convert.ToDouble(input5);
            Console.WriteLine("The square of the user input value is {0:0.00}", output5);
        }
    }
}
