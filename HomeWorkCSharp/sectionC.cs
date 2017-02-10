using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionC
    {
        public static void Main()
        {
           
            //Q1
            Console.WriteLine("\nQ1");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your gender? \nKey in M for male and F for female");
            string gender = Console.ReadLine();

            if ((gender == "M") || (gender == "m"))
            {
                Console.WriteLine("Hi Mr {0}", name);

            }
            else if ((gender == "F") || (gender == "f"))
            {
                Console.WriteLine("Hi Ms {0}", name);
            }
            else
                Console.WriteLine("Please key in a valid gender!");
            
            //Q2
            Console.WriteLine("/nQ2");
            Console.WriteLine("What is your name?");
            string name2 = Console.ReadLine();
            Console.WriteLine("What is your gender? \nKey in M for male and F for female");
            string gender2 = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age2 = Convert.ToInt32(Console.ReadLine());

            if ((gender2 == "M") || (gender2 == "m"))
            {
                if ((age2 >= 0) && (age2 < 45))
                    Console.WriteLine("Hi Mr {0}", name2);
                if (age2 >= 45)
                    Console.WriteLine("Hi Uncle {0}", name2);
            }
            else if ((gender2 == "F") || (gender2 == "f"))
            {
                if ((age2 >= 0) && (age2 < 45))
                    Console.WriteLine("Hi Ms {0}", name2);
                if (age2 >= 45)
                    Console.WriteLine("Hi Aunty {0}", name2);
            }
            else
                Console.WriteLine("Please key in a valid gender!");
            

            //Q3
            Console.WriteLine("\nQ3");
            Console.WriteLine("What is your marks?");
            double marks = Convert.ToDouble(Console.ReadLine());
            if ((marks >= 80) && (marks <= 100))
            {
                Console.WriteLine("Your marks is {0} and your grade is A", marks);
                return;
            }
            else if ((marks >= 60) && (marks <= 79))
            {
                Console.WriteLine("Your marks is {0} and your grade is B", marks);
                return;
            }
            else if ((marks >= 40) && (marks <= 59))
            {
                Console.WriteLine("Your marks is {0} and your grade is C", marks);
                return;
            }
            else if ((marks >= 0) && (marks <= 40))
            {
                Console.WriteLine("Your marks is {0} and your grade is F", marks);
                return;
            }
            else
                Console.WriteLine("**ERROR**");

            

            //Q4
            Console.WriteLine("\nQ4");
            Console.WriteLine("What is the distance travelled in kilometers?");
            double distance = Convert.ToDouble(Console.ReadLine());
            if (distance <= 0.5)
                Console.WriteLine("Your taxi fare is ${0:0.00}", 2.40);
            else if ( (distance >0.5) && (distance <= 9.0))
                Console.WriteLine("Your taxi fare is ${0:0.00}", 2.40 + Math.Round((distance-0.5)*10*0.04),1);
            else if (distance >9)
                Console.WriteLine("Your taxi fare is ${0:0.00}", Math.Round((2.40 + (9 - 0.5) * 10 * 0.04 + ((distance - 9)*10*0.05)),1));
            

            //Q5
            Console.WriteLine("\nQ5");
            Console.WriteLine("Please enter a 3 digit Number from 100 to 999 to determine if it is an Armstrong number!");
            int number = Convert.ToInt32(Console.ReadLine());
            if( (number<100) || (number>999))
            {
                Console.WriteLine("Please enter a 3 digit number from 100 to 999");
                return;
            }
            //abc = (a * a * a) + (b * b * b) + (c * c * c)   
            int a, b, c;
            a = number / 100;
            b = (number % 100)/10;
            c = number % 10;

            if (number == (a * a * a) + (b * b * b) + (c * c * c))
            {
                Console.WriteLine("True,The number entered is an Armstrong number");
            }
            else
                Console.WriteLine("False, the number entered is not an Armstrong number");

            //Q6
            Console.WriteLine("\nQ6");
            int TV, DVD, MP3;
            Console.WriteLine("Please Indicate the number of TV sold");
            TV = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Indicate the number of DVD sold");
            DVD = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Indicate the number of MP3 sold");
            MP3 = Convert.ToInt32(Console.ReadLine());
            // 10% if more than 5000 and 15% if more than 10,000 valid only for tv and dvd
            // 3 conditions, 1) no discound 2) 10% discount 3) 15% discount
            if ((TV * 900 + DVD * 500 + MP3 * 700 >= 0) && (TV * 900 + DVD * 500 + MP3 * 700 <= 5000))
            {
                Console.WriteLine("Discounted Price is ${0:0,0.00}", (TV * 900 + DVD * 500 + MP3 * 700));
            }
            else if ( (TV*900+ DVD*500 + MP3*700 > 5000) && (TV * 900 + DVD * 500 +MP3 * 700 <= 10000))
            {
                Console.WriteLine("Discounted Price is ${0:0,0.00}", ((TV * 900 + DVD * 500) * 0.9 + MP3 * 700));
            }
            else if ((TV * 900 + DVD * 500 + MP3 * 700 > 10000))
            {
                Console.WriteLine("Discounted Price is ${0:0,0.00}", ((TV * 900 + DVD * 500) * 0.85 + MP3 * 700));
            }

            /*
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            double number;
            bool isParsed = Double.TryParse(input, out number);
            if (!isParsed)
            {
                Console.WriteLine(" You didn't enter a number");
            }
            else
                Console.WriteLine("COngratulations, you can follow instruction!");
                
            //IsParsed will contain if the conversion is success(true) and unsuccessful(false)
            //number is the converted number("input" in double form) 
             
            */
        }
    }
}
