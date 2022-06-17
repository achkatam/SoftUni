using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
            //Your program may receive the following commands:
            //•	Delete { element} – delete all elements in the array, which are equal to the given element.
            //Inser {element} { position} – insert the element at the given position.
            //You should exit the program when you receive the "end" command.Print all numbers in the array separated by a single whitespace.

            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //command
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string cmd = tokens[0];
                //If Check
                if (cmd == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    numbers.RemoveAll(el => el == element);
                    //Using for loop to iterate thru to list
                    //for (int i = 0; i < numbers.Count; i++)
                    //{
                    //    int currEl = numbers[i];
                    //    if (currEl == element)
                    //    {
                    //        numbers.Remove(currEl);
                    //    }
                    //}
                }
                else if (cmd == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, element);
                }
                command = Console.ReadLine();
            }
            //Output
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
