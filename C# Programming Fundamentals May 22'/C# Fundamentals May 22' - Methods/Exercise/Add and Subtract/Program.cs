using System;

namespace Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result = Add(num1, num2);
            int finalResult = Substract(result, num3);
            Print(finalResult);
        }

        private static int Substract(int result, int num3) => result - num3;
        

        private static int Add(int num1, int num2) => num1 + num2;

        static void Print(int number) => Console.WriteLine(number);
    }
}
