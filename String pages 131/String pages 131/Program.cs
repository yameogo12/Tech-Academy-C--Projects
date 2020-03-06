using System;

namespace String_pages_131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string firstName = "Samuel";
            Console.WriteLine(firstName);

            String lastName = "Yameogo";
            Console.WriteLine(lastName);

            string midName = "Sam";
            Console.WriteLine(midName);

            string name = "Samuel Sam  Yameogo";
            name = name.ToUpper();
            Console.WriteLine(name);

            String quote = "Madames, Moidemoiselles, et Messiers. \"Bonjour\",\nBonjour Tonton nouvelle ligne.\n \t Bonjour mes amies.";
            Console.WriteLine(quote);


            StringBuilder sb = StringBuilder();
            sb.Append("Je m'appel Samuel");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
