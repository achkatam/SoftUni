using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // M E T H O D S
            int sum = AddNumbers(4, 60);
            Console.WriteLine(sum);
        }

        public static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
