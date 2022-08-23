using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int dayfOfWeek = int.Parse(Console.ReadLine());
            string[] days =
            {
                "Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "Sunday"
            };
            //Solution
            //if (dayfOfWeek >= 1 && dayfOfWeek <= 7)
            //{
            //    Console.WriteLine(days[dayfOfWeek - 1]);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Day!");
            //}

            //Ternary operator
            string result = (dayfOfWeek >= 1 && dayfOfWeek <= 7) ?
                days[dayfOfWeek - 1] : "Invalid day!";
            Console.WriteLine(result);
        }
    }
}
