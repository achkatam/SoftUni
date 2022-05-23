using System;

namespace Dsihwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottlesDetergernt = int.Parse(Console.ReadLine());
            int totalDetergnet = bottlesDetergernt * 750;

            int totalPlates = 0;
            int totalPots = 0;
            int usedDetergent = 0;

            
            int refillWasher = 0;

            while(totalDetergnet >= 0)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{totalPlates} dishes and {totalPots} pots were washed.");
                    Console.WriteLine($"Leftover detergent {totalDetergnet- usedDetergent} ml.");
                    break;

                }
                else
                {
                    totalPlates += int.Parse(input);
                    refillWasher++;
                    if (refillWasher % 3 == 0)
                    {
                        totalPots += totalPlates;
                        totalDetergnet -= totalPots * 15;
                        
                    }
                    else
                    {
                        totalPlates += totalPlates;
                        totalDetergnet -= totalPlates * 5;
                    }
                }

            }
            if (totalDetergnet <0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(totalDetergnet)} ml. more necessary!");

            }


        }
    }
}

