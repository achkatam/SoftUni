using System;

namespace Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            //minutes += 30;

            ////output
            //if(minutes >= 60)
            //{
            //    minutes -= 60;
            //    hours++;
            //}
            //if (hours == 24)
            //{
            //    hours = 0;
            //}

            //Console.WriteLine($"{hours}:{minutes:00}");

            TimeSpan h = TimeSpan.FromHours(hours);
            TimeSpan m = TimeSpan.FromMinutes(minutes);

            TimeSpan time = h + m.Add(TimeSpan.FromMinutes(30));

            Console.WriteLine($"{time.Hours}:{time.Minutes:00}");
        }
    }
}
