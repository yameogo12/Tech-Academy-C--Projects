using System;

namespace page_90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine(" Enter your hourly earnings");
            int hourlyWages = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("Now, enter how many hours per week you work");
            int weeklysalary = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
         
            

            int total1 = hourlyWages  * weeklysalary * 52;
            Console.WriteLine(total1 + " This is your yearly salary!");
            Console.ReadLine();

            

            Console.WriteLine(" your Friend Name");
            Console.ReadLine();

            Console.WriteLine("enter your friend HourlyWages");
            int hishourlyWages = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter how many does he works per week?");
            int hisweeklySalary = Convert.ToInt32(Console.ReadLine());

            int total3 = hishourlyWages * hisweeklySalary * 52;
            Console.WriteLine(total3 + " This is your Friend yearly salary!");
            Console.ReadLine();

            bool trueOrFalse = total1  > total3;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();
            Console.ReadLine();

        }
    }
}
