using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the list for targets
            var targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            //Vartiable for the command received from the console
            string command = Console.ReadLine();
            //While loop 
            while (command != "End")
            {
                //add-ons
                string[] tokens = command.Split();
                string cmd = tokens[0];
                //Swtich case to iterate thru all the command cases
                switch (cmd)
                {
                    //Shoot {index} {power}"
                    case "Shoot":
                        Shoot(int.Parse(tokens[1]), int.Parse(tokens[2]), targets);
                        break;
                    //Add {index} {value}"
                    case "Add":
                        Add(int.Parse(tokens[1]), int.Parse(tokens[2]), targets);

                        break;
                    case "Strike":
                        //"Strike {index} {radius}"
                        Strike(int.Parse(tokens[1]), int.Parse(tokens[2]), targets);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join('|', targets));
        }

        private static void Strike(int index, int radius, List<int> targets)
        {
            //"Strike {index} {radius}"
            //o Remove the target at the given index and the ones before and after it, depending on the radius.
            //o If any of the indices in the range is invalid, print: "Strike missed!" and skip this command.
            //Check if index is in the bounds
            if (index < 0 || index > targets.Count - 1
                || index - radius < 0
                || index + radius > targets.Count - 1)
            {
                Console.WriteLine("Strike missed!");

                return;
            }

            targets.RemoveRange(index - radius, radius * 2 + 1);

        }

        private static void Add(int index, int value, List<int> targets)
        {
            // Insert a target with the received value at the received index, if it exists.
            //o If not, print: "Invalid placement"
            if (index < 0 || index > targets.Count - 1)
            {
                Console.WriteLine("Invalid placement!");

                return;
            }

            targets.Insert(index, value);
        }

        static void Shoot(int index, int power, List<int> targets)
        {
            //o Shoot the target at the index, if it exists, by reducing its value by the given power(integer value). 
            //o Remove the target, if it is shot.A target is considered shot when its value reaches 0
            //Check if index is in array
            if (index < 0 || index > targets.Count - 1)
            {
                return;
            }

            targets[index] -= power;

            if (targets[index] <= 0)
            {
                targets.RemoveAt(index);
            }
        }
    }
}
