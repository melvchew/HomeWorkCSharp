using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionG4
    {
        public static void Main()
        {
            string[,] prog = new string[,] { { "Name", "Marks" },
                                             { "John", "63" },
                                             { "Venkat", "29" },
                                             { "Mary", "75" },
                                             { "Victor", "82" },
                                             { "Betty", "55" }
                                           };
            //Console.WriteLine(prog.GetLength(0)); //6
            //Console.WriteLine(prog.GetLength(1)); //2
            for (int h = 2; h < prog.GetLength(0); h++) //range of i  = (0, 6)
            {
                for (int i = 1; i < prog.GetLength(0) - 1; i++) //range of h = (0,5)
                {

                    if (prog[i, 0].CompareTo(prog[i + 1, 0]) > 0) //change to < or > to change the sorting order
                    {

                        string temp = prog[i, 0]; //this switches the names
                        prog[i, 0] = prog[i + 1, 0];
                        prog[i + 1, 0] = temp;
                        string temp2 = prog[i, 1]; //this switches the scores
                        prog[i, 1] = prog[i + 1, 1];
                        prog[i + 1, 1] = temp2;
                    }

                }
                for (int i = 1; i < prog.GetLength(0); i++) //use another for loop to do printing of name and marks
                {
                    Console.WriteLine("{0}\t{1}", prog[i, 0], prog[i, 1]);
                }




            }
            Console.WriteLine("Sort by marks!");
            for (int h = 2; h < prog.GetLength(0); h++) //range of i  = (0, 6)
            {
                for (int i = 1; i < prog.GetLength(0) - 1; i++) //range of h = (0,5)
                {

                    if (prog[i, 1].CompareTo(prog[i + 1, 1]) < 0) // change to < or > to change the sorting order.
                    {

                        string temp = prog[i, 0]; //this switches the names
                        prog[i, 0] = prog[i + 1, 0];
                        prog[i + 1, 0] = temp;
                        string temp2 = prog[i, 1]; //this switches the scores
                        prog[i, 1] = prog[i + 1, 1];
                        prog[i + 1, 1] = temp2;
                    }

                }
                for (int i = 1; i < prog.GetLength(0); i++) //use another for loop to do printing of name and marks
                {
                    Console.WriteLine("{0}\t{1}", prog[i, 0], prog[i, 1]);
                }
            }
        }
    }
}

    

