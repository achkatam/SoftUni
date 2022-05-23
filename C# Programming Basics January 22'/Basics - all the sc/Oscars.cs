using System;

namespace _06.Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());

            for (int i = 1; i <= jury; i++)
            {
                string assessorName = Console.ReadLine();
                double assessorPoints = double.Parse(Console.ReadLine());

                academyPoints += assessorName.Length * assessorPoints / 2;

                if(academyPoints >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }
            }
            if(academyPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {Math.Abs(academyPoints-1250.5):f1} more!");
            }
           
        }
    }
}
