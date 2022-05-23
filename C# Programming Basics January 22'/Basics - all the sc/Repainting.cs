using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //prices
            double cover = 1.50;
            double paint = 14.50;
            double thinner = 5;
            double bags = 0.40;

            //input
            int coverC = int.Parse(Console.ReadLine());
            int paintC = int.Parse(Console.ReadLine());
            int thinnerC = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            //calculations
            double coverT = coverC + 2;
            double paintT = paintC +paintC * 0.10;
            double materials = coverT * cover + paintT * paint + thinnerC * thinner + bags;
            double payroll = materials * 0.30;
            double payrollT = payroll * hours;
            double total = payrollT + materials;

            //output
            Console.WriteLine(total);

        }
    }
}
