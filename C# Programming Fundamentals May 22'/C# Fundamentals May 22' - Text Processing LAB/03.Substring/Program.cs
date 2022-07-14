using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string input = Console.ReadLine();

            while (input.Contains(wordToRemove))
            {
                int startIndex = input.IndexOf(wordToRemove);
                input = input.Remove(startIndex, wordToRemove.Length);
            }

            Console.WriteLine(input);
        }
    }
}
