using System;

namespace InchesToCM
{
    class Program
    {
        static void Main(string[] args)
        {
            double cm = 2.54;
            double inch = double.Parse(Console.ReadLine());
            double total= inch * cm;
            Console.WriteLine(total);

        }
    }
}
