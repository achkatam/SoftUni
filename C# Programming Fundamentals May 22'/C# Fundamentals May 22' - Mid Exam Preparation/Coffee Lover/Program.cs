using System;
using System.Collections.Generic;
using System.Linq;

namespace Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            //List
            var coffees = Console.ReadLine().Split().ToList();

            int numOfCommands = int.Parse(Console.ReadLine());

            string command = "";

            for (int i = 0; i < numOfCommands; i++)
            {
                command = Console.ReadLine();
                string[] tokens = command.Split();
                string cmd = tokens[0];

                //switch case to check the variaties of commands
                switch (cmd)
                {
                    case "Include":
                        Include(coffees, tokens[1]);
                        break;
                    case "Remove":
                        Remove(coffees, tokens[1], int.Parse(tokens[2]));
                        break;
                        //Prefer index1 index2
                    case "Prefer":
                        Prefer(coffees, int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "Reverse":
                        Reverse(coffees);
                        break;
                }
            }
            Console.WriteLine("Coffees: ");
            Console.WriteLine(string.Join(' ', coffees));
        }

        private static void Reverse(List<string> coffees)
        {
            coffees.Reverse();
        }

        private static void Prefer(List<string> coffees, int index1, int index2)
        {
            if (index1 >= 0 && index1 <= coffees.Count-1
                && index2 >= 0 && index2 <= coffees.Count - 1)
            {
                string tempCoffee = coffees[index1];
                coffees[index1] = coffees[index2];
                coffees[index2] = tempCoffee;

            }

            return;
        }

        private static void Remove(List<string> coffees, string firstOrLast, int countsToRemove)
        {
            if (coffees.Count > countsToRemove)
            {
                if (firstOrLast == "first")
                {
                    for (int i = 0; i < countsToRemove; i++)
                    {
                        coffees.RemoveAt(0);
                    }
                }
                else if (firstOrLast == "last")
                {
                    for (int i = 0; i < countsToRemove; i++)
                    {
                        coffees.RemoveAt(coffees.Count - 1);
                    }
                }
            }

            return;
        }

        private static void Include(List<string> coffees, string item)
        {
            //Add item at the end of list
            coffees.Add(item);
        }
    }
}
