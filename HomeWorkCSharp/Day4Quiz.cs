using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class Day4Quiz
    {
        public static void Main()
        {
            string pin = "0";
            int count = 1;
            Console.WriteLine("Welcome to the bank of ISS");
            Console.Write("Please enter your 6 digit pin: \t");  pin = Console.ReadLine();
            while (count <3)
            {
                while(pin != "123456")
                {
                    Console.WriteLine("Incorrect pin, Please try again!");
                    Console.Write("Please enter your 6 digit pin again: \t"); pin = Console.ReadLine();
                    count++;
                    if (count == 3)
                    {
                        Console.WriteLine("Too many incorrect entry, your account will be locked!");
                        break;
                    }
                    
                
                }
                if (pin == "123456")
                    break;
            }
        }
    }
}
