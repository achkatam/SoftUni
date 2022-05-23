using System;

namespace Invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //type in int number 100-200 || =0
            int num = int.Parse(Console.ReadLine());
            //
            if (num >= 100 && num <=200 || num == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
