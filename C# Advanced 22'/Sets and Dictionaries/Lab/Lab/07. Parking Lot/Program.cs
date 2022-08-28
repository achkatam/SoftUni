using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that:
            //Records a car number for every car that enters the parking lot.
            //Removes a car number when the car leaves the parking lot.
            //The input will be a string in the format: "direction, carNumber".You will be receiving commands until the "END" command is given.
            //Print the car numbers of the cars, which are still in the parking lot:

            //new hashSet
            var parkingLot = new HashSet<string>();

            //input commands, plate number
            string command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.Split(','
                    , StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];
                string plateNumber = tokens[1];

                switch (cmd)
                {
                    case "IN":
                        parkingLot.Add(plateNumber);
                        break;
                    case "OUT":
                        parkingLot.Remove(plateNumber);
                        break;
                }

                command = Console.ReadLine();
            }

            if (parkingLot.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");

                return;
            }

            Console.WriteLine(string.Join("\n",parkingLot));
        }
    }
}
