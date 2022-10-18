using System;

namespace _02._Recursive_Factorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(num));

        }

        public static int Factorial(int num)
        {
            //factorial always start fom 1, so we should subtract until num euqals 1
            if (num == 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
    }
}
