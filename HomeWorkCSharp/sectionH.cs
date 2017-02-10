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
    }
}
