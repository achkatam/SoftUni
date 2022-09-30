using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that executes some mathematical operations on a given collection. On the first line, you are given a list of numbers. On the next lines, you are passed different commands that you need to apply to all the numbers in the list:
            //•	"add"->add 1 to each number
            //•	"multiply"->multiply each number by 2
            //•	"subtract"->subtract 1 from each number
            //•	"print"->print the collection
            //•	"end"->ends the input
            //Note: Use functions.

            //input
            List<int> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            Action<List<int>> printer = nums => Console.WriteLine(String.Join(" ", nums));

            string command = Console.ReadLine();

            while (command != "end")
            {

                if (command == "print")
                {
                    printer(input);

                    command = Console.ReadLine();
                    continue;
                }

                Func<int, int> operations = ApplyArithmetics(command);
                //apply the operations to the list
                input = input.Select(num => operations(num)).ToList();

                command = Console.ReadLine();
            }
        }
        static Func<int, int> ApplyArithmetics(string command)
        {
            switch (command)
            {
                case "add":
                    return num => num + 1;
                    break;
                case "multiply":
                    return num => num * 2;
                    break;
                case "subtract":
                    return num => num - 1;
                    break;
                //without default case the code breaks
                default:
                    return null;
                    break;
            }
        }
    }
}
