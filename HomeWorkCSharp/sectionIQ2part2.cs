using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionIQ2part2
    {
        public static void Main()
        {
            int[] x = new int[10];
            Random rnd = new Random();
            string[] count = new string[10]
            { "","","","","","","","","",""};

            for (int i = 0; i < 50; i++)
            {
                int y = rnd.Next(0, 10);
                if (y == 0)
                    count[0] = count[0] + "*";
                if (y == 1)
                    count[1] = count[1] + "*";
                if (y == 2)
                    count[2] = count[2] + "*";
                if (y == 3)
                    count[3] = count[3] + "*";
                if (y == 4)
                    count[4] = count[4] + "*";
                if (y == 5)
                    count[5] = count[5] + "*";
                if (y == 6)
                    count[6] = count[6] + "*";
                if (y == 7)
                    count[7] = count[7] + "*";
                if (y == 8)
                    count[8] = count[8] + "*";
                if (y == 9)
                    count[9] = count[9] + "*";
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} : {1}", i, count[i]);
            }

        }
    }
}
