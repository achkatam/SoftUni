using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            //sizes = input
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            //1 liter = 1 cubic decemeter = 0.001 L

            //calculations
            double volume = lenght * width * height;
            double volumeinliters = volume * 0.001;
            double liters = volumeinliters * (1 - (percent / 100));

            //output
            Console.WriteLine(liters);

        }
    }
}
