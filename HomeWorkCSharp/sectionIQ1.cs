using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionIQ1
    {
        
public static void Main()
        {
            double amt = 0.001;
            while (amt < 0.01)
            {
                Console.WriteLine("Please enter an amount in DD.CC exact to the 2 decimal places");
                amt = Convert.ToDouble(Console.ReadLine());
            }
            //denomination of 100, 50 20.10.5 cents
            amt = (amt) * 100;
            double hundredcents = 0;
            double fiftycents = 0;
            double twentycents = 0;
            double tencents = 0;
            double fivecents = 0;
            
            if((amt / 100) > 0)
                {
                hundredcents = Math.Floor(((amt) / 100));
                }
            amt = amt - hundredcents * 100;
            if ((amt / 50) > 0)
            {
                fiftycents = Math.Floor(((amt) / 50));
            }
            amt = amt - (fiftycents * 50);
            if ((amt / 20) > 0)
            {
                twentycents = Math.Floor(((amt) / 20));
            }
            amt = amt - twentycents * 20;
            if ((amt / 10) > 0)
            {
                tencents = Math.Floor(((amt) / 10));
            }
            amt = amt - tencents * 10;
            if ((amt / 5) > 0)
            {
                fivecents = Math.Floor(((amt) / 5));
            }
            

            Console.WriteLine("The number of 100cents is : {0}\nThe Number of 50cents is : {1}\nThe Number of 20cents is :{2}\nThe Number of 10cents is :{3}\nThe Number of 5cents is :{4}", hundredcents, fiftycents, twentycents, tencents, fivecents);
        }
    }
}
