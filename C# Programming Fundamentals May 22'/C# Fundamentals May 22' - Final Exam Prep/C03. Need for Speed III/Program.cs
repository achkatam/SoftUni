using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace C03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the standard input, you will receive an integer n – the number of cars that you can obtain. On the next n lines, the cars themselves will follow with their mileage and fuel available, separated by "|" in the following format:
            //"{car}|{mileage}|{fuel}"

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            //variable for car numbers to be added in the dictionary
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split("|"
                    , StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                cars[model] = new Car(mileage, fuel);
            }

            //Then, you will be receiving different commands, each on a new line, separated by " : ", until the "Stop" command is given:
            string command = Console.ReadLine();

            const int MAX_MILEAGE = 100000;
            const int MAX_TANK_CAPABILITY = 75;
            const int MAX_MILEAGE_TO_REVERT = 10000;

            while (command != "Stop")
            {
                string[] tokens = command.Split(" : "
                    , StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];
                string model = tokens[1];

                switch (cmd)
                {
                    case "Drive":
                        //•	"Drive : {car} : {distance} : {fuel}":
                        {
                            Drive(cars, MAX_MILEAGE, tokens, model);
                        }
                        break;
                    case "Refuel":
                        {
                            Refuel(cars, MAX_TANK_CAPABILITY, tokens, model);
                        }
                        break;
                    case "Revert":
                        Revert(cars, MAX_MILEAGE_TO_REVERT, tokens, model);
                        break;
                }

                command = Console.ReadLine();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }

        private static void Revert(Dictionary<string, Car> cars, int MAX_MILEAGE_TO_REVERT, string[] tokens, string model)
        {
            int kms = int.Parse(tokens[2]);

            cars[model].Mileage -= kms;

            if (cars[model].Mileage < MAX_MILEAGE_TO_REVERT)
            {
                cars[model].Mileage = MAX_MILEAGE_TO_REVERT;
            }

            Console.WriteLine($"{model} mileage decreased by { kms} kilometers");
        }

        private static void Refuel(Dictionary<string, Car> cars, int MAX_TANK_CAPABILITY, string[] tokens, string model)
        {
            int fuelToRefill = int.Parse(tokens[2]);

            if (cars[model].Fuel + fuelToRefill > MAX_TANK_CAPABILITY)
            {
                fuelToRefill = MAX_TANK_CAPABILITY - cars[model].Fuel;
            }

            cars[model].Fuel += fuelToRefill;

            Console.WriteLine($"{model} refueled with {fuelToRefill} liters");
        }

        private static void Drive(Dictionary<string, Car> cars, int MAX_MILEAGE, string[] tokens, string model)
        {
            int distance = int.Parse(tokens[2]);
            int fuelConsumed = int.Parse(tokens[3]);

            if (cars[model].Fuel < fuelConsumed)
            {
                Console.WriteLine($"Not enough fuel to make that ride");
            }
            else
            {
                cars[model].Fuel -= fuelConsumed;
                cars[model].Mileage += distance;
                Console.WriteLine($"{model} driven for {distance} kilometers. {fuelConsumed} liters of fuel consumed.");
            }

            if (cars[model].Mileage >= MAX_MILEAGE)
            {
                cars.Remove(model);

                Console.WriteLine($"Time to sell the {model}!");
            }
        }
    }
    class Car
    { 
        public Car(int mileage, int fuel)
        {
            Mileage = mileage;
            Fuel = fuel;
        }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
