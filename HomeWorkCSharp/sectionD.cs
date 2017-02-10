using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionD
    {
        public static void Main()
        {
/*
            //Q1
            Console.WriteLine("\nQ1");
            int x = 0;
            while (x != 88)
            {
                Console.WriteLine("Please key in the number");
                x = Convert.ToInt32(Console.ReadLine());
            }
            if (x == 88)
                Console.WriteLine("lucky you.....");
            
            //Q2
            Console.WriteLine("\nQ2");
            Console.WriteLine("Please key in an integer number for A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please key in an integer number for B");
            int B = Convert.ToInt32(Console.ReadLine());
            int a = A;
            int b = B;
            while( a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                if (b > a)
                {
                    b = b - a;
                }
            }
            int HCF = a;
            int LCM = (A * B) / HCF;
            Console.WriteLine("The HCF is {0} and LCM is {1}", HCF, LCM);
            
            //Q3
            Console.WriteLine("\nQ3");
            int x3 = 0;
            int count = 0;
            Random r = new Random(); //creating a random object, and assigning to r
            int randomNumber = r.Next(0, 10); //give random from 0 to 9
            while (randomNumber != x)
            {
                Console.WriteLine("PLease enter a number from 0 to 9");
                x3 = Convert.ToInt32(Console.ReadLine());
                count++;
                if ((count >= 3) && (randomNumber != x3))
                {
                    Console.WriteLine("You are lousy!");
                }
                if ((randomNumber == x3) && (count<3))
                    Console.WriteLine("You are a wizard!");
                if ((randomNumber == x3) && (count >=3))
                    Console.WriteLine("You are a lousy wizard!");
            }
            */
            //Q4
            Console.WriteLine("\nQ4");
            Console.WriteLine("Please enter a number");
            double N = Convert.ToDouble(Console.ReadLine());
            Random r4 = new Random();
            int randomNumber4 = r4.Next(0, 100);
            double G = Convert.ToDouble(randomNumber4) / 100 * N;
            //Console.WriteLine(G); // just checking the value of G
            if (G * G == N)
                Console.WriteLine("The number input is {0:0.} and the square root of the number is {1:0.###}", N, G);
            while(Math.Round(G*G, 5) != N)
            {
                G = (G + (N/G)) / 2;
            }
            Console.WriteLine("The number input is {0:0.} and the square root of the number is {1:0.###}", N, G);
            //input number N, guess number G that is between 1 and N
            //G*G == N , if not
            // output G : Math.Round(G = (G + N/G)/2, 5)
            
       

        }
    }
}
