using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string concat = Console.ReadLine();

            Console.WriteLine($"{name1}{concat}{name2}");
        }
    }
}
