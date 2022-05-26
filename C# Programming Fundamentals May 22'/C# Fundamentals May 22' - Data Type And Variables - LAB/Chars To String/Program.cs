using System;

namespace Chars_To_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputs = new char[3];

            inputs[0] =char.Parse(Console.ReadLine());
            inputs[1] =char.Parse(Console.ReadLine());
            inputs[2] =char.Parse(Console.ReadLine());

            Console.WriteLine($"{inputs[0]}{inputs[1]}{inputs[2]}");

        }
    }
}
