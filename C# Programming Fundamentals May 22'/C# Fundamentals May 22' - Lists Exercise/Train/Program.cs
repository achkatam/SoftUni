using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line, we will receive a list of wagons(integers). Each integer represents the number of passengers that are currently in each wagon of a passenger train. On the next line, you will receive the max capacity of a wagon represented as a single integer. Until you receive the "end" command, you will be receiving two types of input:
            //•	Add { passengers} – add a wagon to the end of the train with the given number of passengers.
            //•	{ passengers}
            //-find a single wagon to fit all the incoming passengers(starting from the first wagon).
            //In the end, print the final state of the train(all the wagons separated by a space).

            //Create the list
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Variable for max capacity
            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            //while loop
            while (command != "end")
            {
                //Array 
                string[] tokens = command.Split();
                if (tokens.Length == 2)
                {
                    int addWagon = int.Parse(tokens[1]);//The wagon will be at index 1
                    wagons.Add(addWagon);
                }
                else
                {
                    int passanger = int.Parse(tokens[0]);
                    FindWagon(wagons, capacity, passanger);
                }
                command = Console.ReadLine();
            }
            //Output
            Console.WriteLine(string.Join(' ', wagons));

        }

        private static void FindWagon(List<int> wagons, int capacity, int passanger)
        {
            //for loop to iterate thru the list
            for (int i = 0; i < wagons.Count; i++)
            {
                int currWagon = wagons[i];
                if (currWagon + passanger <= capacity)
                {
                    wagons[i] += passanger;
                    break;
                }

            }
        }
    }
}
