using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize list
            var numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string cmd = tokens[0];

                //Switch case to check all the manipulations
                switch (cmd)
                {
                    case "swap":
                        Swap(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                        break;
                    case "multiply":
                        Multiply(int.Parse(tokens[1]), int.Parse(tokens[2]), numbers);
                        break;
                    case "decrease":
                        Decrease(numbers);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Decrease(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i]--;
            }
        }

        private static void Multiply(int firstIndex, int secondIndex, List<int> numbers)
        {
            numbers[firstIndex] = numbers[firstIndex] * numbers[secondIndex];
        }

        private static void Swap(int firstIndex, int secondIndex, List<int> numbers)
        {
            //"swap {index1} {index2}" takes two elements and swap their places
            int firstNum = numbers[firstIndex];
            int secondNum = numbers[secondIndex];

            //Create tempNum
            int tempNum = numbers[firstIndex];

            //swapping the nums
            numbers[firstIndex] = numbers[secondIndex];
            numbers[secondIndex] = tempNum;

        }
    }
}
