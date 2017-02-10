using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionB
    {
        public static void Main()
        {
            //Q1
            Console.WriteLine("Q1");
            Console.WriteLine("PLease enter a double from 0 to 100");
            string input = Console.ReadLine();
            double output = Convert.ToDouble(input);
            Console.WriteLine("The Square root of the user input value is {0}", Math.Sqrt(output));

            //Q2
            Console.WriteLine("Q2");
            Console.WriteLine("PLease enter a double from 0 to 100");
            string input2 = Console.ReadLine();
            double output2 = Convert.ToDouble(input2);
            Console.WriteLine("The Square root of the user input value is {0:0.000}", Math.Sqrt(output2));

            //Q3
            Console.WriteLine("Q3");
            Console.WriteLine("PLease enter your salary");
            string input3 = Console.ReadLine();
            double output3 = Convert.ToDouble(input3);
            Console.WriteLine("The total income is ${0:0.00}", output3 *1.13);

            //Q4
            
            Console.WriteLine("Q4");
            Console.WriteLine("PLease enter the temperature in degree celcius");
            string input4 = Console.ReadLine();
            double output4 = Convert.ToDouble(input4);
            Console.WriteLine("The temperature in farenheit is {0:000}", (1.8*output4)+32);

            //Q5
            Console.WriteLine("Q5");
            Console.WriteLine("for the equation : y =  5*x*x - 4*x +3 ");
            Console.WriteLine("PLease enter the value of x");
            string input5 = Console.ReadLine();
            double output5 = Convert.ToDouble(input5);
            Console.WriteLine("The value of y is {0}", ((5*output5*output5) - (4*output5) +3));

            //Q6
            Console.WriteLine("Q6");
            Console.WriteLine("Please enter the coordinates X1");
            double X1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the coordinates Y1");
            double Y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the coordinates X2");
            double X2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the coordinates Y2");
            double Y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Distance between the two points is {0}", Math.Sqrt((X2-X1)*(X2-X1) + (Y2-Y1)*(Y2-Y1)));
            Console.WriteLine("The Distance between the two points is {0}", Math.Sqrt(Math.Pow(X2 - X1,2) + Math.Pow(Y2 - Y1,2)));

            //Q7
            Console.WriteLine("Q7");
            Console.WriteLine("Please enter the distance travelled in kilometres");
            double input7 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total fare is {0:0.00#}", (2.40 + (0.4 * input7)));

            //Q8
            Console.WriteLine("Q8");
            Console.WriteLine("Please enter the distance travelled in kilometres");
            double input8 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The total fare is {0:0.00}", Math.Round(2.40 + (0.4 * input8), 1));

            //Q9
            Console.WriteLine("Q9");
            Console.WriteLine("Please enter the distance travelled in kilometres");
            double input9 = Convert.ToDouble(Console.ReadLine());
            double temp = (2.40 + (0.4 * input9)) * 10;
            temp = Math.Ceiling(temp) / 10;
            Console.WriteLine("The total fare is {0:0.00}", temp);

            //Q10
            Console.WriteLine("Q10");
            Console.WriteLine("Please enter the value of a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the value of c");
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c)/2;
            if((s-a)*(s-b)*(s-c)<0)
            {
                Console.WriteLine("error, will return imaginary number!");
                return;
            }
            if (s < 0)
            {
                Console.WriteLine("error, will return imaginary number!");
                return;
            }
            Console.WriteLine("the output/Area is {0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));// can just use a if else statement
        }
    }
}
