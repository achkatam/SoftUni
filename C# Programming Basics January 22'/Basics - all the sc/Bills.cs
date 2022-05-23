using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double totalElectricty = 0;
            double water = 20 * months ;
            double internet = 15 * months ;
            double others = 0;

            for (int i = 1; i <= months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                others += (35 + electricity)+ ((35 + electricity) * 0.2);
                totalElectricty += electricity;
               


            }
            Console.WriteLine($"Electricity: {totalElectricty:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {others:f2} lv");
            Console.WriteLine($"Average: {(totalElectricty+water+internet+others)/months:f2} lv");
        }
    }
}
