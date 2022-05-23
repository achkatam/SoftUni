using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            //input 
            int neededHours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = 8;
            int offDays = 2;
            double workingHours = days - (days * 0.1);

            //calculation
            double training = workingHours * workDays;
            double overTime = workers * (offDays * days);
            double totalHours = training + overTime;

            //Conditional check
            if (totalHours >= neededHours)
            {
                double leftHours = totalHours - neededHours;
                Console.WriteLine($"Yes!{Math.Floor(leftHours)} hours left.");
            }
            else if (totalHours < neededHours)
            {
                double hours = neededHours - totalHours;
                Console.WriteLine($"Not enough time!{Math.Ceiling(hours)} hours needed.");
            }


        }
    }
}
