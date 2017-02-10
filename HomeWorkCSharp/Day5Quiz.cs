using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class Day5Quiz
    {
        public static void Main()
        {
            
            Console.WriteLine("Please Key in your & char matriculation number");
            string mat = Console.ReadLine();
            while (mat.Length != 7)
            {
                Console.WriteLine("Invalid Matriculation NUmber!");
                Console.WriteLine("Please Key in your & char matriculation number again");
                mat = Console.ReadLine();
            }
            string Mat = mat.ToUpper();
            int a, b, c, d, e, f;
            int sum;
            a = 6*Convert.ToInt32(Mat.Substring(1, 1));
            b = 5*Convert.ToInt32(Mat.Substring(2, 1));
            c = 4*Convert.ToInt32(Mat.Substring(3, 1));
            d = 3*Convert.ToInt32(Mat.Substring(4, 1));
            e = 2*Convert.ToInt32(Mat.Substring(5, 1));
            sum = a + b + c + d + e;
            f = sum % 5;
            string last;
            switch (f)
            {
                case 0:
                    {
                        last = "O";
                        if (Mat.Substring(6, 1) == last)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                    }
                    break;
                case 1:
                    {
                        last = "P";
                        if (Mat.Substring(6, 1) == last)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                    }
                    break;
                case 2:
                    {
                        last = "Q";
                        if (Mat.Substring(6, 1) == last)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                    }
                    break;
                case 3:
                    {
                        last = "R";
                        if (Mat.Substring(6, 1) == last)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                    }
                    break;
                case 4:
                    {
                        last = "S";
                        if (Mat.Substring(6, 1) == last)
                            Console.WriteLine("Valid");
                        else
                            Console.WriteLine("Invalid");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            
           

            
        }   
    }
}
