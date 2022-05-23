using System;

namespace On_Time_For_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            TimeSpan examHour = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan examMinutes = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));
            TimeSpan arrivalHour = TimeSpan.FromHours(int.Parse(Console.ReadLine()));
            TimeSpan arrivalMinutes = TimeSpan.FromMinutes(int.Parse(Console.ReadLine()));

            TimeSpan examTime = examHour + examMinutes;
            TimeSpan arrivalTime = arrivalHour + arrivalMinutes;

            if (examTime - arrivalTime >= TimeSpan.FromMinutes(0) && examTime - arrivalTime <= TimeSpan.FromMinutes(30))
            {
               if (examTime == arrivalTime)
                {
                    Console.WriteLine("On time");
                }
                else if (examTime - arrivalTime <= TimeSpan.FromMinutes(30))
                {
                    examTime -= arrivalTime;
                    Console.WriteLine("On time");
                    Console.WriteLine($"{examTime.Minutes} minutes before the start");
                }
            }
            else if (examTime - arrivalTime > TimeSpan.FromMinutes(30) && examTime - arrivalTime <=TimeSpan.FromMinutes(59) || examTime - arrivalTime > TimeSpan.FromMinutes(59))
            {
                if (examTime - arrivalTime <= TimeSpan.FromMinutes(59))
                {
                    examTime -= arrivalTime;
                    Console.WriteLine($"Early");
                    Console.WriteLine($"{examTime.Minutes} minutes before the start");
                }
                else if (examTime - arrivalTime > TimeSpan.FromMinutes(59))
                {
                    examTime -= arrivalTime;
                    Console.WriteLine($"Early");
                    Console.WriteLine($"{examTime.Hours}:{examTime.Minutes:00} hours before the start");
                }
            }
            else if (arrivalTime > examTime)
            {
                if (arrivalTime - examTime <= TimeSpan.FromMinutes(59))
                {
                    arrivalTime -= examTime;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{arrivalTime.Minutes} minutes after the start");
                }
                else if (arrivalTime - examTime > TimeSpan.FromMinutes(59))
                {
                    arrivalTime -= examTime;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{arrivalTime.Hours}:{arrivalTime.Minutes:00} hours after the start");
                }
            }

        }
    }
}
