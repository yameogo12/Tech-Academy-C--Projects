using System;
using System.Collections.Generic;

namespace Iteration_page_141
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] houses = { "townhouse", "treehouse", "appartment" };
            Console.WriteLine(" Choose a cool name");
            string Name = Console.ReadLine();
            
            
           // string sentence1 = Console.ReadLine();
           // Console.WriteLine("your  firt sentence is ," + sentence1);

            //for (int x = 0; x < houses.Length; x--)
            //{
            //    Console.WriteLine("houses:{0}", x);
            //}
            //Console.ReadLine();

          
            
            foreach(string house in houses)
              {
                Console.WriteLine(Name + house);
                
                }
                Console.ReadLine();
            }




            //foreach (int x = 0; x < houses.Length; x++)
            //{
              //  if (houses[x] < 3)  
               //{
                 //   Console.WriteLine(" " + houses[x]);
                //}
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "townhouse", "treehouse", "appartment" };

            //foreach (string name in names)
            //{

            //  {
            //   Console.WriteLine(name + names);
            // }
            // }
            // Console.ReadLine();


            //List<string> names = new List<string>() { "townhouse", "treehouse", "appartment" };

            //foreach (string name in names)
            //{
            //    if (name == "townhouse")
            //    {
            //        Console.WriteLine(name);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "townhouse","townhome","treehouse","treehouse","appartment"};
            //List<string> coolNames = new List<string>();
            //foreach (string real in names)
            //{
            //    if(real == "")
            //    {
            //        coolNames.Add("names");
            //   }
            //}




            //Console.WriteLine(coolNames.Count);
            //Console.ReadLine();

        }
    }

