using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Create a program that prints the spoken language in a country. You will receive only the following combinations:
            //•	English is spoken in England and the USA.
            //•	Spanish is spoken in Spain, Argentina, and Mexico.
            //•	For the others, we should print "unknown".
            //Input
            //You will receive a single line of input, representing the country name.
            //Output
            //Print the language that is spoken in the given country.In case the country is unknown for the program, print "unknown".



            //input
            string country = Console.ReadLine();

            switch (country)
            {
                case "England":
                case "USA":
                    Console.WriteLine($"English");
                    break;
                case "Spain":
                case "Mexico":
                case "Argentina":
                    Console.WriteLine($"Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }


        }
    }
}
