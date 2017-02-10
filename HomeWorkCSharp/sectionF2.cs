using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionF2
    {
        public static void Main()
        {
            int[] Array = new int[] { 9,2,6,1,2,3,5,6,1, 5, 2, 3, 5, 7, 8, 4, 2, 9,1,2,3,8 };
            for (int j = 0; j<Array.Length; j++)
            {
                for (int i = 0; i < Array.Length - j-1; i++)
                {
                    if (Array[i] > Array[i + 1])
                    {
                        int temp = Array[i];
                        Array[i] = Array[i + 1];
                        Array[i + 1] = temp;
                    }
                }
                /*
                for (int j = 1; j <Array.Length -1 ;j++)
                {
                    
                }
                */
                for (int h = 0; h < Array.Length; h++)
                {
                    Console.Write(Array[h]);
                }
                Console.WriteLine();
                
            }
        }
    }
}
