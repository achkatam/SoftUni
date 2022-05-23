using System;

namespace Tennis_rank
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int tournamentsCount = int.Parse(Console.ReadLine());
            int pointsBeginning = int.Parse(Console.ReadLine());

            double wonTournaments = 0;
            int wonPoints = 0;
            for (int i = 1; i <= tournamentsCount; i++)
            {
                string stageTournament = Console.ReadLine();

                if (stageTournament == "W")
                {
                    wonPoints += 2000;
                    wonTournaments++;
                }
                else if (stageTournament == "F")
                {
                    wonPoints += 1200;
                }
                else if (stageTournament == "SF")
                {
                    wonPoints += 720;
                }
            }
            wonPoints += pointsBeginning;
            Console.WriteLine($"Final points: {wonPoints}");
            Console.WriteLine($"Average points: {Math.Floor((wonPoints-pointsBeginning)/tournamentsCount*1.0)}");
            Console.WriteLine($"{wonTournaments/tournamentsCount*100:f2}%");
        }
    }
}
