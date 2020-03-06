using System;

namespace Tech_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string input1 = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("What page number?");
            string mypagenumber = Console.ReadLine();
            int mynumber = Convert.ToInt32(mypagenumber);
            int total = mynumber + 1;
            Console.WriteLine("my page number is 1: " + total);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything?");
            bool needhelp = true;
            Console.WriteLine("need help");
            Console.ReadLine();

            Console.WriteLine("Where there any positive experiences you'd like to share?", " Please give specifics");
            string input2 = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("how many hours did you study today");
            string hourstudy = Console.ReadLine();
            int hours = Convert.ToInt32(hourstudy);
            Console.WriteLine("total hours today is 1: " + hourstudy);
            Console.ReadLine();

        }
    }
}
