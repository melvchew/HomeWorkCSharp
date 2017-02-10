using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionE
    {
        public static void Main()
        {
            
            //Q1a
            Console.WriteLine("Please input an integer!");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            int temp = 1;
            while (count <=  n)
            {
                
                temp = temp * count;
                count++;
                
            }
            Console.WriteLine("The factorial is {0}", temp);
            
            //Q1b
            Console.WriteLine("Please input an integer!");
            int n1b = Convert.ToInt32(Console.ReadLine());
            int count1b = n; // decrement means that the count will start from n.
            int temp1b = 1;
            while ((count1b <= n1b) && (count1b !=0)) // without the counter !=0, the while look will run forever.
            {

                temp1b = temp1b * count1b;
                count1b--;

            }
            Console.WriteLine("The factorial is {0}", temp1b);
            

            //Q2
            //use a for loop
            //must create the title first
            Console.WriteLine("NO.\tInverse\tSquareRoot\tSquare");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0:0.0s}\t{1:0.0##}\t{2:0.0##}\t\t{3:0.0}", i, 1 / i, Math.Sqrt(i), i * i);
            }
           

            //Q3
            //to determine if an input integer is a prime number
            //A prime number (or a prime) is a natural number greater than 1 that has no positive divisors other than 1 and itself
            Console.WriteLine("please input an integer!"); 
            int input3 = Convert.ToInt32(Console.ReadLine());
            int count3 = 0;
            for (int i = 1; i<= input3;  i++)
            {
                if (input3 % i == 0)
                    count3++;

            }
            if (count == 2) // since a prime number is only divisible by itself and 1 thus only 2 counts.
                Console.WriteLine("The input integer is a Prime Number");
            else
                Console.WriteLine("The input integer is not a Prime Number");
            
       

            //Q4
            //check if the inout is a perfect number.
            Console.WriteLine("please input an integer!");
            int input4 = Convert.ToInt32(Console.ReadLine());
            int temp4 = 0;
            for (int i = 1; i < input4; i++)
            {
                if (input4 % i == 0)
                    temp4 = temp4 + i;

            }
            if (input4 == temp4)
                Console.WriteLine("The input is a Perfect Number!");
            else
                Console.WriteLine("The input is not a Perfect Number!");

            
            //Q5
            for (int j = 5; j <= 10000; j++)
            {
                int count5 = 0;
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                        count5++;

                }
                if (count5 == 2) // since a prime number is only divisible by itself and 1 thus only 2 counts.
                    Console.WriteLine(j);
        
            }
            


            //Q6
            for (int j = 1; j <= 1000; j++)
            {
                int temp6 = 0;
                for (int i = 1; i < j; i++)
                {
                    if (j % i == 0)
                        temp6 = temp6 + i;

                }
                if (j == temp6)
                    Console.WriteLine(j);
                
            }
        }

    }
}
