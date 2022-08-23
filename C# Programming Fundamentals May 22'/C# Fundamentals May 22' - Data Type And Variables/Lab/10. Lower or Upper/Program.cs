using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints whether a given character is upper-case or lower case.

            char ch = char.Parse(Console.ReadLine());

            if (Char.IsUpper(ch))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
