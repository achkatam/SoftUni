using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that reads a line of text from the console. Print all the words that start with an uppercase letter in the same order you've received them in the text.


            Func<string, bool> isUpper = w => char.IsUpper(w[0]) == true;

            Console.WriteLine(String.Join("\n",
                Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(isUpper)
                .ToArray()));

            //Predicate<string> isUpper = w => char.IsUpper(w[0]);

            //Console.WriteLine(string.Join(Environment.NewLine, 
            //    Array.FindAll(Console.ReadLine()
            //    .Split(" ", StringSplitOptions.RemoveEmptyEntries), isUpper)));

        }
    }
}
