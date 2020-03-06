using System;

namespace page100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What's your name");
            Console.ReadLine();

            Console.WriteLine(" what is your age?");
            Console.ReadLine();

            Console.WriteLine("have you ever had a DUI?");
            bool trueOrFalse = Convert.ToBoolean(Console.ReadLine());
            

            Console.WriteLine("How many speeding tickets do you have?");
            int number = Convert.ToInt32(Console.ReadLine());

            if (trueOrFalse == true || number > 3)
            {
                Console.WriteLine("Not qualified");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Qualified");
                Console.ReadLine();
            }
            


        }
    }
}


