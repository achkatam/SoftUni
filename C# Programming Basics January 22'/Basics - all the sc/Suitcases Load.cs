using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double trunkSpace = double.Parse(Console.ReadLine());

            string commmand = string.Empty;

            double suitcaseVol = 0;
            int suitcaseCount = 0;
            double totalVol = 0;
            while ((commmand=Console.ReadLine()) != "End")
            {
                suitcaseVol = double.Parse(commmand);
                totalVol += suitcaseVol;
                if (commmand =="End" || totalVol >= trunkSpace)
                {
                    
                    break;
                }
                suitcaseCount++;

            }
            if (commmand == "End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            else if (totalVol >= trunkSpace)
            {
                Console.WriteLine($"No more space!");
            }
            Console.WriteLine($"Statistic: {suitcaseCount} suitcases loaded.");

        }
    }
}
