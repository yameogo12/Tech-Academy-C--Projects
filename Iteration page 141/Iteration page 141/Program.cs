using System;
using System.Collections.Generic;

namespace Iteration_page_141
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] houses = { "townhouse", "treehouse", "appartment" };
            //Console.WriteLine("put some text here");
            //string sentence1 = Console.ReadLine();
            //Console.WriteLine("your  firt sentence is ," + sentence1);

            //  for ( int x = 0; x <houses.Length; x--)
            // {
            //  Console.WriteLine("houses:{0}" , x);
            // }
            //Console.ReadLine();

            //for (int x = 0; x <houses.Length; x++)
            //{
            //    Console.WriteLine(houses[x]);
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() { "townhouse", "treehouse", "appartment" };

            //foreach (string name in names)
            //{
                
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() { "townhouse", "treehouse", "appartment" };

            //foreach (string name in names)
            //{
            //    if (name == "townhouse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            List<string> names = new List<string>() { "townhouse","townhome","treehouse","treehouse","appartment"};
            List<string> coolNames = new List<string>();
            foreach (string real in names)
            {
                if(real == "treehouse")
                {
                    coolNames.Add("names");
                }
            }
            Console.WriteLine(coolNames.Count);
            Console.ReadLine();

        }
    }
}
