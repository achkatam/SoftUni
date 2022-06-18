using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {


            //Create a program that reads a list of integers.Then until you receive "end", you will receive different commands:


            //Next, we are going to implement more complicated list commands, extending the previous task. Again, read a list and keep reading commands until you receive "end":

            //After the end command, print the list only if you have made some changes to the original list. 
            
            //CHANGES ARE MADE ONLY FROM THE COMMANDS FROM THE PREVIOUS TASK

            //boolean if there is any changes
            bool hasBeenChanged = false;

            //Initialize the list of integers
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //command
            string command = Console.ReadLine();
            //while until end
            while (command != "end")
            {
                //Initialize array of tokens represnting the inputed commands
                string[] tokens = command.Split();
                //easier operating
                string cmd = tokens[0];

                switch (cmd)
                {
                    //•	Add { number}: add a number to the end of the list.
                    case "Add":
                        int num = int.Parse(tokens[1]);
                        Add(num, numbers);
                        hasBeenChanged = true;
                        break;
                    //•	Remove { number}: remove a number from the list
                    case "Remove":
                        Remove(int.Parse(tokens[1]), numbers);
                        hasBeenChanged = true;
                        break;
                    //•	RemoveAt { index}: remove a number at a given index
                    case "RemoveAt":
                        int index = int.Parse(tokens[1]);
                        RemoveAt(index, numbers);
                        hasBeenChanged = true;
                        break;
                    // Insert {number} { index}: insert a number at a given index.
                    case "Insert":
                        int numToInsert = int.Parse(tokens[2]);
                        int indexToInsert = int.Parse(tokens[1]);
                        Insert(numToInsert, indexToInsert, numbers);
                        hasBeenChanged = true;
                        break;
                    //•	Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
                    case "Contains":
                        Contains(int.Parse(tokens[1]), numbers);
                        break;
                    //•	PrintEven – print all the even numbers, separated by a space.
                    case "PrintEven":
                        PrintEven(numbers);
                        break;
                    //•	PrintOdd – print all the odd numbers, separated by a space.
                    case "PrintOdd":
                        PrintOdd(numbers);
                        break;
                    //•	GetSum – print the sum of all the numbers.
                    case "GetSum":
                        GetSum(numbers);
                        break;
                    //  Filter { condition} { number} – print all the numbers that fulfill the given condition.The condition will be either '<', '>', ">=", "<=".
                    case "Filter":
                        Filter(tokens[1], int.Parse(tokens[2]), numbers);
                        break;
                }
                command = Console.ReadLine();
            }
            if (hasBeenChanged)
            {
                Console.WriteLine(string.Join(' ', numbers));
            }

        }

        private static void Filter(string condition, int num, List<int> numbers)
        {
            switch (condition)
            {
                case "<":
                    foreach (var number in numbers)
                    {
                        if (number < num)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case "<=":
                    foreach (var number in numbers)
                    {
                        if (number <= num)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">":
                    foreach (var number in numbers)
                    {
                        if (number > num)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
                case ">=":
                    foreach (var number in numbers)
                    {
                        if (number >= num)
                        {
                            Console.Write($"{number} ");
                        }
                    }
                    Console.WriteLine();
                    break;
            }
        }

        private static void GetSum(List<int> numbers)
        {
            Console.WriteLine(numbers.Sum());
        }

        private static void PrintOdd(List<int> numbers)
        {
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }

        private static void PrintEven(List<int> numbers)
        {
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.Write($"{num} ");
                }
            }
            Console.WriteLine();
        }

        private static void Contains(int num, List<int> numbers)
        {
            Console.WriteLine(numbers.Contains(num) ? "Yes" : "No such number");
        }

        private static void Insert(int num, int index, List<int> numbers)
        {
            numbers.Insert(num, index);
        }

        private static void RemoveAt(int index, List<int> numbers)
        {
            numbers.RemoveAt(index);
        }

        private static void Remove(int num, List<int> numbers)
        {
            numbers.Remove(num);
        }

        private static void Add(int num, List<int> numbers)
        {
            numbers.Add(num);
        }
    }
}

