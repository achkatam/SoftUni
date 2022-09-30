using System;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You are given a lower and an upper bound for a range of integer numbers. Then a command specifies if you need to list all even or odd numbers in the given range. Use Predicate<T>.

            //create predicate 
            Predicate<int> isEvenNum = num => num % 2 == 0;

            //array of int for startNum and endNum
            int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            string command = Console.ReadLine();

            for (int i = input[0]; i <= input[1]; i++)
            {
                if (command == "even" && isEvenNum(i))
                {
                    Console.Write(i + " ");
                }
                else if (command == "odd" && !isEvenNum(i))
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
