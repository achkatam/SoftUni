using System;

namespace Sleepy_Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            // 30 000 min/year   = 500 h/year = 20.83 days/year
            //workDays = 63 min/day
            //dayOff = 127 min/day

            //input
            int daysOff = int.Parse(Console.ReadLine());
            int norm = 30000;
            //calculation
            int daysOffPlay = daysOff * 127;
            int workDaysPlay = (365 - daysOff) * 63;
            int playTime = daysOffPlay + workDaysPlay;            
            int difference = norm - playTime;
            double hours = difference / 60;
            int min = difference % 60;


            if (playTime > norm)
            {
                
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(min)} minutes more for play");
                
            }
            else if ( playTime < norm)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Abs(hours)} hours and {Math.Abs(min)} minutes less for play ");
            }
        }
    }
}
