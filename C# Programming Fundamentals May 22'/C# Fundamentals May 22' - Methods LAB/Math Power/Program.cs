using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(num, power));
        }
        //Two parameters in the method, then print the result
        static double MathPower(double num, int power)
        {
            double result = 0;
            //Using MathPow
            return Math.Pow(num, power);
        }
    }
}
