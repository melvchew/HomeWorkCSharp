using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp
{
    class sectionF3
    {
        public static void Main()
        {
            int[,] marks = new int[12, 4] { { 56, 84, 68, 29 },  //following the marks given
                                            { 94, 73, 31, 96 }, 
                                            { 41, 63, 36, 90 }, 
                                            { 99, 9, 18, 17 }, 
                                            { 62, 3, 65, 75 }, 
                                            { 40, 96, 53, 23 }, 
                                            { 81, 15, 27, 30 }, 
                                            { 21, 70, 100, 22 }, 
                                            { 88, 50, 13, 12 }, 
                                            { 48, 54, 52, 78 }, 
                                            { 64, 71, 67, 25 },
                                            { 16, 93, 46, 72 } };
            //compute the total marks obtained for each student
            for (int i =0; i <12; i++) //run a for loop for each student
            {
                double total = 0;
                for(int j = 0; j < 4; j++) // run a for loop for all the subjects
                {
                    total = total + marks[i, j];
                }
                Console.WriteLine("The no. {0} student's total marks is {1} and the average score is {2}", i, total, total/4);
            }
            
            //compute the class average 
            for (int i = 0; i <  4; i++) 
            {
                double total = 0; // this finds the average score of each subject
                for (int j = 0; j < 12; j++)
                {
                    total = total + marks[j,i];
                }
                Console.WriteLine("The class average is {0:0.##} for subject {1}", total / 12, i);
            }

            //compute the standard deviation of marks for each subjects

            for (int i = 0; i < 4; i++)
            {
                double total = 0; // this finds the average score of each subject
                for (int j = 0; j < 12; j++)
                {
                    total = total + marks[j, i];
                    
                }
                double average = total / 12; //can try to GetLength
           /*     double variance = 0;
                double sum = 0;
                for (int h = 0; h <12; h++)
                for(int h = 0; h<4; h++)
                    {
                        for (int k = 0; k<12;k++)
                        {

                        }
                    } */
                Console.WriteLine("The class average is {0:0.##} for subject {1}", total / 12, i);
            }
            // this finds the average score of all students and all subjects
            double Total = 0;
            for (int i = 0; i < 4; i++)
            {
                double total = 0; 
                for (int j = 0; j < 12; j++)
                {
                    Total = Total + marks[j, i];
                }
                
            }
            Console.WriteLine("The overall average of marks for the whole class of all subjects is {0}", Total / marks.Length);


        }
    }
}
