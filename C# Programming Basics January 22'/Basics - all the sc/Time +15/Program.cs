using System;

namespace Time__15
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            TimeSpan hour = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan min = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));
            TimeSpan time = hour + min.Add(TimeSpan.FromMinutes(15));
            //output
            Console.WriteLine($"{time.Hours}:{time.Minutes:00}");
        }
    }
}
