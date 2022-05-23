using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            string sport = "";
            string winOrLose = "";

            double dailyMoney = 0;
            double totalMoney = 0;
            int winsCounter = 0;
            int losesCounter = 0;
            int totalWins = 0;
            int totalLoses = 0;

            for (int i = 1; i <= days; i++)
            {
                while ((sport = Console.ReadLine()) != "Finish")
                {
                    winOrLose = Console.ReadLine();
                    if (winOrLose == "win")
                    {
                        winsCounter++;
                        dailyMoney += 20;
                    }
                    else
                    {
                        losesCounter++;
                    }
                }
                if (winsCounter > losesCounter)
                {
                    dailyMoney += dailyMoney * 0.1;
                }

                totalLoses += losesCounter;
                totalWins += winsCounter;
                totalMoney += dailyMoney;


                
            }
            if (totalWins > totalLoses)
            {
                totalMoney += totalMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:f2}");
            }
        }
    }
}
