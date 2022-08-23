using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a program that reads a list of integers.Then until you receive "end", you will receive different commands:

            //Note: All the indices will be valid!
            //When you receive the "end" command, print the final state of the list(separated by spaces).

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
                        break;
                    //•	Remove { number}: remove a number from the list
                    case "Remove":
                        Remove(int.Parse(tokens[1]), numbers);
                        break;
                    //•	RemoveAt { index}: remove a number at a given index
                    case "RemoveAt":
                        int index = int.Parse(tokens[1]);
                        RemoveAt(index, numbers);
                        break;
                    // Insert {number} { index}: insert a number at a given index.
                    case "Insert":
                        int numToInsert = int.Parse(tokens[2]);
                        int indexToInsert = int.Parse(tokens[1]);
                        Insert(numToInsert, indexToInsert, numbers);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', numbers));
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
