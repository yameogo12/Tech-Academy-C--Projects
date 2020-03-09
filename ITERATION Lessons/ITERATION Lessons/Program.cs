using System;
using System.Collections.Generic;

namespace ITERATION_Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //    //Console.WriteLine("Hello World!");
            //    //Console.ReadLine();

            //    int[] testScores = { 98, 99, 95, 85, 70, 82, 34, 91, 90, 94 };

            //    for (int i = 0; i < testScores.Length; i ++ )
            //    {
            //        if (testScores[i] > 85)
            //        {
            //            Console.WriteLine("Passing test score: " + testScores[i]);
            //         }
            //     }

            //Console.ReadLine();

            string[] names = { "sam", "yam", "sidbe" };

            for (int y = 0; y < names.Length; y++)
            {
                if (names[y] == "yam")
                {
                    Console.WriteLine(names[y]);
                }
            }
            Console.ReadLine();

            for (int y = 0; y < names.Length; y++)
            {
                Console.WriteLine(names[y]);
            }
            Console.WriteLine();



        }
    }
}



    
    
