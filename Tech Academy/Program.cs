using System;

namespace Page89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give me any number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int product = num1 * 50;
            Console.WriteLine(num1 + " times 50 = " + product);

            Console.WriteLine(" Again choose your number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            double result1 = num2 / 12.5;
            Console.WriteLine(num2 + " Divide by 12.5 = " + result1);

            Console.WriteLine(" choose a number");
            int num3 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = num3 > 50;
            Console.WriteLine(trueOrFalse.ToString());

            Console.WriteLine(" user input ");
            int num4 = Convert.ToInt32(Console.ReadLine());
            int remainder = num4 % 7;
            Console.WriteLine(num4 + "divide by 7 = " + remainder );



            Console.ReadLine();
        }
    }
}
