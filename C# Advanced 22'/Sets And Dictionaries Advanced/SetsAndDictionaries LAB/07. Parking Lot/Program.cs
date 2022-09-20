using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that:
            //•	Records a car number for every car that enters the parking lot.
            //•	Removes a car number when the car leaves the parking lot.
            //The input will be a string in the format: "direction, carNumber".You will be receiving commands until the "END" command is given.
            //Print the car numbers of the cars, which are still in the parking lot:

            var set = new HashSet<string>();

            //input
            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split(",", StringSplitOptions.RemoveEmptyEntries);

                string direction = tokens[0];
                string plateNum = tokens[1];

                if (direction == "IN")
                {
                    if (!set.Contains(plateNum))
                    {
                        set.Add(plateNum);
                    }
                }
                else
                {
                    set.Remove(plateNum);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(set.Count > 0 ? String.Join("\n", set) : "Parking Lot is Empty");
        }
    }
}
