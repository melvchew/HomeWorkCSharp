using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionH
    {
        public static void Main()
        {
            //Q1
            Console.WriteLine("{0}",InString("Jerome rocks", "rocks"));
            //Q2
            //Console.WriteLine("{0}", FindWord("The brown fox", "fox"));
            //Q3
            Console.WriteLine("please input an integer!");
            double a = Convert.ToDouble(Console.ReadLine());
            double div = a;
            double remainder = a;
            string conversion = "";
            //Console.WriteLine(temp);
            //Console.WriteLine(temp2);
            while (div >= 16 )
            {
                remainder = div % 16;
                div = div / 16;
                div = Math.Floor(div);
                
                if (remainder == 0)
                    conversion = "0" + conversion;
                if (remainder == 1)
                    conversion = "1" + conversion;
                if (remainder == 2)
                    conversion = "2" + conversion;
                if (remainder == 3)
                    conversion = "3" + conversion;
                if (remainder == 4)
                    conversion = "4" + conversion;
                if (remainder == 5)
                    conversion = "5" + conversion;
                if (remainder == 6)
                    conversion = "6" + conversion;
                if (remainder == 7)
                    conversion = "7" + conversion;
                if (remainder == 8)
                    conversion = "8" + conversion;
                if (remainder == 9)
                    conversion = "9" + conversion;
                if (remainder == 10)
                    conversion = "A" + conversion;
                if (remainder == 11)
                    conversion = "B" + conversion;
                if (remainder == 12)
                    conversion = "C" + conversion;
                if (remainder == 13)
                    conversion = "D" + conversion;
                if (remainder == 14)
                    conversion = "E" + conversion;
                if (remainder == 15)
                    conversion = "F" + conversion;
            }
            Console.WriteLine(div + conversion);
        }

        static bool InString(string s1, string s2)
        {
            //determine length of s2
            //use a for loop running through s1 to see .EqualsTO s2
            //return results true or false
            
            int count = 0;
            for (int i = 0; i< s1.Length - s2.Length+1; i++)
            {
                
                if (s1.Substring(i, s2.Length).ToUpper().Equals(s2.ToUpper()))
                    count++;
                
            }
            if (count > 0)
            {

                return true;
            }
            else
                return false;
        }
        static int FindWord(string s1, string s2)
        {
            //determine length of s2
            //use a for loop running through s1 to see .EqualsTO s2
            //return results true or false

            int count = 0;
            for (int i = 0; i < s1.Length - s2.Length + 1; i++)
            {

                if (s1.Substring(i, s2.Length).ToUpper().Equals(s2.ToUpper()))
                    break;
                else
                    count++;
            }
            if (count >= 0)
            {

                return count;
            }
            else
                return -1;
        }

        /*static string Hexadecimal(int a)
        {
            


        }
        */
    }
}
