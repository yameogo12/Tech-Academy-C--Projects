using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            // title
            Console.WriteLine(" I am a  Mathematian Genius!");

            // addition
            int total = 5 + 10;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.ReadLine();

            // another way to addition
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();

            // soustraction or difference in C#
            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " +difference.ToString());
            Console.Read();

            // Product or Multiplication
            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            // Division or Quotien
            int quotient = 100 / 5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            // Remainder 
            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();


            int num1 = 200 / 3;
            Console.WriteLine(num1);
            Console.WriteLine();

            // comparaison

            bool trueOrFalse = 12 < 5;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            int roomTemperature = 70;
            int currentTemperature = 72;

            bool isWarm = currentTemperature > roomTemperature;
            //bool isWarm = currentTemperature >= roomTemperature;
            //bool isWarm = currentTemperature == roomTemperature;
           // bool isWarm = currentTemperature != roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

        }
    }
}
