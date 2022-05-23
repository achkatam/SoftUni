using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfLoad = int.Parse(Console.ReadLine());

            double totalTons = 0;

            int vanTons = 0;
            int trucktons = 0;
            int trainTons = 0;
            


            for (int i = 1; i <= countOfLoad; i++)
            {
                int tons = int.Parse(Console.ReadLine());

                totalTons += tons;
                
                if (tons <= 3)
                {
                    vanTons += tons;
                }
                else if (tons <=11)
                {
                    trucktons += tons;
                }
                else 
                {
                    trainTons += tons;
                }

            }
            double averagePrice = (vanTons * 200 + trucktons * 175 + trainTons * 120)/totalTons;

            double vanPercentage = vanTons / totalTons * 100.0;
            double truckPercentage = trucktons / totalTons * 100.0;
            double trainPercentage = trainTons / totalTons * 100.0;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{vanPercentage:f2}%");
            Console.WriteLine($"{truckPercentage:f2}%");
            Console.WriteLine($"{trainPercentage:f2}%");

        }
    }
}
