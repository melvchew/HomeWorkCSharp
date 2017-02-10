using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HomeWorkCSharp
{
    class sectionG
    {
        public static void Main()
        {
            /*
            //Q1
            Console.WriteLine("Please input a phrase");
            string input = Console.ReadLine();
            int counta = 0;
            int counte = 0;
            int counti = 0;
            int counto = 0;
            int countu = 0;
            Console.WriteLine(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                if((input.Substring(i,1)== "a") || (input.Substring(i, 1) == "A")) // i could also just upper case or lower case the entire string before checking
                {
                    counta++;
                }
                if ((input.Substring(i, 1) == "e") || (input.Substring(i, 1) == "E"))
                {
                    counte++;
                }
                if ((input.Substring(i, 1) == "i") || (input.Substring(i, 1) == "I"))
                {
                    counti++;
                }
                if ((input.Substring(i, 1) == "o") || (input.Substring(i, 1) == "O"))
                {
                    counto++;
                }
                if ((input.Substring(i, 1) == "u") || (input.Substring(i, 1) == "U"))
                {
                    countu++;
                }

            }
            Console.WriteLine("Total vowels:\t{0}\nA:\t\t{1}\nE:\t\t{2}\nI:\t\t{3}\nO:\t\t{4}\nU:\t\t{5}", counta + counte + counti + counto + countu, counta, counte, counti, counto, countu);
            

            //Q2a
            //check if the word is palindrome
            Console.WriteLine("Please enter a word");
            string input2 = Console.ReadLine();
            //Console.WriteLine(input2.Length);
            //Console.WriteLine(input2.Length/2);
            int count2 = 0;
            for(int i = 0; i < input2.Length/2; i++)
            {
                if (input2.Substring(i, 1) == input2.Substring(input2.Length - 1 - i, 1))
                    count2++;

            }
            //Console.WriteLine(count2);
            if (count2 ==  (input2.Length/2))
                Console.WriteLine("The word is a palindrom");
            else
                Console.WriteLine("The word is not a palindrom");


            
            //Q2b
            //check if the word is palindrome

            //i need to check all to a upper or lower case
            //remove the spaces?
            Console.WriteLine("Please enter a phrase/sentence");
            string input2b = Console.ReadLine();
            input2b = input2b.Replace(" ", "");
            for(int i = 0 ; i <input2b.Length ; i++)
            {   
                if((input2b.substring(i,1).ToUpper != "A") ||
                    (input2b.substring(i,1).ToUpper != "B") ||
                    (input2b.substring(i,1).ToUpper != "C") ||
                    (input2b.substring(i,1).ToUpper != "D") ||
                    (input2b.substring(i,1).ToUpper != "E") ||
                    (input2b.substring(i,1).ToUpper != "F") ||
                    (input2b.substring(i,1).ToUpper != "G") ||
                    (input2b.substring(i,1).ToUpper != "H") ||
                    (input2b.substring(i,1).ToUpper != "I") ||
                    (input2b.substring(i,1).ToUpper != "J") ||
                    (input2b.substring(i,1).ToUpper != "K") ||
                    (input2b.substring(i,1).ToUpper != "L") ||
                    (input2b.substring(i,1).ToUpper != "M") ||
                    (input2b.substring(i,1).ToUpper != "N") ||
                    (input2b.substring(i,1).ToUpper != "O") ||
                    (input2b.substring(i,1).ToUpper != "P") ||
                    (input2b.substring(i,1).ToUpper != "Q") ||
                    (input2b.substring(i,1).ToUpper != "R") ||
                    (input2b.substring(i,1).ToUpper != "S") ||
                    (input2b.substring(i,1).ToUpper != "T") ||
                    (input2b.substring(i,1).ToUpper != "U") ||
                    (input2b.substring(i,1).ToUpper != "V") ||
                    (input2b.substring(i,1).ToUpper != "W") ||
                    (input2b.substring(i,1).ToUpper != "X") ||
                    (input2b.substring(i,1).ToUpper != "Y") ||
                    (input2b.substring(i,1).ToUpper != "Z") ||
                    (input2b.substring(i,1).ToUpper != "0") ||
                    (input2b.substring(i,1).ToUpper != "1") ||
                    (input2b.substring(i,1).ToUpper != "2") ||
                    (input2b.substring(i,1).ToUpper != "3") ||
                    (input2b.substring(i,1).ToUpper != "4") ||
                    (input2b.substring(i,1).ToUpper != "5") ||
                    (input2b.substring(i,1).ToUpper != "6") ||
                    (input2b.substring(i,1).ToUpper != "7") ||
                    (input2b.substring(i,1).ToUpper != "8") ||
                    (input2b.substring(i,1).ToUpper != "9") ||
                    (input2b.substring(i,1).ToUpper != "10") ||
                    {



                    
                
            input2b = input2b.ToUpper();
            //Console.WriteLine(input2b.Length);
            //Console.WriteLine(input2b.Length / 2);
            int count2b = 0;
            for (int i = 0; i < input2b.Length / 2; i++)
            {
                if (input2b.Substring(i, 1) == input2b.Substring(input2b.Length - 1 - i, 1))
                    count2b++;

            }
            //Console.WriteLine(count2b);
            if (count2b != (input2b.Length/2) )
                Console.WriteLine("The phrase/sentence is not a palindrom");
            else
                Console.WriteLine("The phtase/sentence is a palindrom");
            
            

            //Q3
            /*   
            //method 1
            Console.WriteLine("Please enter a phrase/sentence");
            string input3 = Console.ReadLine();
            for (int i = 0; i < input3.Length; i++)
            {
                //if (input3.Substring(i, 1) == " ")
                Console.Write(input3.Substring(i, 1));

            }
            Console.WriteLine("");
            Console.Write(input3.Substring(0,1).ToUpper()); // the first letter always upper case, if its a space then it will still be a space
            for (int i = 1; i < input3.Length; i++)
            {
                if (input3.Substring(i - 1, 1) == " ") //check the i-1 of the string is a space " ", if it is i will be printed as a uppercase.
                    Console.Write(input3.Substring(i, 1).ToUpper());
                else
                    Console.Write(input3.Substring(i, 1).ToLower());

            }
            Console.WriteLine();
            */
            //method 2
            Console.WriteLine("Please enter a phrase/sentence");
            string input3 = Console.ReadLine();
            for (int i = 0; i < input3.Length; i++)
            {
                //if (input3.Substring(i, 1) == " ")
                Console.Write(input3.Substring(i, 1));

            }
            Console.WriteLine("");
            string input3a = (input3.Substring(0,1).ToUpper());  // the first letter always upper case, if its a space then it will still be a space //HeLP -> Help
            for (int i = 1; i < input3.Length; i++)
            {
                if (input3.Substring(i - 1, 1) == " ")           //check the i-1 of the string is a space " ", if it is i will be printed as a uppercase.
                    input3a = input3a + (input3.Substring(i, 1).ToUpper());
                else
                    input3a = input3a + (input3.Substring(i, 1).ToLower());

            }
            Console.WriteLine(input3a);
                  
            //Q4
            //string[,] marks = new string[5, 2] { { "John", "63" }, { "Venkat", "29" }, { "Mary", "75" }, { "Victor", "82" }, { "Betty", "55" } };



        }
    }
}
