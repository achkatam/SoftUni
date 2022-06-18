using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //The first input line will hold a list of integers. Until we receive the "End" command, we will be given operations we have to apply to the list.
            //The possible commands are:

            //Create list
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                //Create array of operations
                string[] tokens = command.Split();
                string cmd = tokens[0];

                //Using switch case and create methods
                switch (cmd)
                {
                    case "Add":
                        int num = int.Parse(tokens[1]);
                        Add(numbers, num);
                        break;
                    case "Insert":
                        int number = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        if (index < 0 || index >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            Insert(numbers, number, index);
                        }
                        break;
                    case "Remove":
                        int indeX = int.Parse(tokens[1]);
                        if (indeX < 0 || indeX >= numbers.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        Remove(numbers, indeX);
                        break;
                    case "Shift":
                        int count = int.Parse(tokens[2]);
                        if (tokens[1] == "right")
                        {
                            ShiftRight(numbers, count);
                        }
                        else if (tokens[1] == "left")
                        {
                            ShiftLeft(count, numbers);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void ShiftLeft(int count, List<int> numbers)
        {
            //•	Shift left {count} – first number becomes last. This has to be repeated the specified number of times
            //Use for loop
            for (int i = 0; i < count; i++)
            {
                //Initialize tempNum for the first number of the list
                int tempNum = numbers[0];

                for (int index = 0; index < numbers.Count - 1; index++)
                {
                    numbers[index] = numbers[index + 1];

                }
                //last digit becomes tempNum
                numbers[numbers.Count - 1] = tempNum;
            }
        }

        static void ShiftRight(List<int> numbers, int count)
        {
            //•	Shift right {count} – last number becomes first. To be repeated the specified number of times
            //Using for loop to iterate thru the list/array
            for (int i = 0; i < count; i++)
            {
                //Initialize tempNum for the last number/ the end of the list
                int tempNum = numbers[numbers.Count - 1];
                //Reversed for loop
                for (int j = numbers.Count - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }
                numbers[0] = tempNum;
            }
        }
        static void Add(List<int> numbers, int num)
        {
            numbers.Add(num);
        }
        //•	Insert {number} {index} – insert the number at the given index
        static void Insert(List<int> numbers, int num, int index)
        {
            numbers.Insert(index, num);
        }
        //•	Remove {index} – remove the number at the given index
        static void Remove(List<int> numbers, int index)
        {
            numbers.RemoveAt(index);
        }
    }
}