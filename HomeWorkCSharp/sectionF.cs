using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionF
    {
        public static void Main()
        {
            
            //Q1a
            string[,] Sales = new string[12, 2] { { "January", "0" }, { "Febuary", "0" }, { "March", "0" } , { "April", "0" } , { "May", "0" } , { "June", "0" } , { "July", "0" } , { "August", "0" } , { "September", "0" } , { "October", "0" } , { "November", "0" } , { "December", "0"}  };
            Console.WriteLine(Sales[0, 0]);
            Console.WriteLine(Sales.Length);
            for (int i = 0; i < 12 ; i++)
            {
                Console.WriteLine("Please enter the sales for the month of {0}", Sales[i, 0]);
                Sales[i, 1] = Console.ReadLine();  
            }
            for (int i = 0; i < 12 ; i++)
            {
                Console.WriteLine("The sales for {0}:\t  {1}", Sales[i, 0],Sales[i,1]);
            }

            //Q1b &Q1
            int max = Convert.ToInt32(Sales[0, 1]);
            int min = Convert.ToInt32(Sales[0, 1]);
            int MAX = 0;
            int MIN = 0;
            int TotalSales = 0;
            for (int i  = 0; i<12; i++)
            {

                if (Convert.ToInt32(Sales[i, 1]) > max)
                {
                    max = Convert.ToInt32(Sales[i, 1]);
                    MAX = i;
                }
                if (Convert.ToInt32(Sales[i, 1]) < min)
                {
                    min = Convert.ToInt32(Sales[i, 1]);
                    MIN = i;
                }
                TotalSales = TotalSales + Convert.ToInt32(Sales[i, 1]);

            }
            Console.WriteLine("The Max sales recorded is {0} on the month of {1}", Sales[MAX,1], Sales[MAX, 0]);
            Console.WriteLine("The Min sales recorded is {0} on the month of {1}", Sales[MIN,1], Sales[MIN, 0]);
            Console.WriteLine("The average sales recorded is {0}", TotalSales/12 );
        }
    }
}
