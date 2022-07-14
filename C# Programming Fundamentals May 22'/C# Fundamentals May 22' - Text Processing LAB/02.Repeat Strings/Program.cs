using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split();

            var result = string.Empty;

            foreach (var word in strings)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }

            Console.WriteLine(result);
        }
    }
}
