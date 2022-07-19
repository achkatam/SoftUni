using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            //On the first line of the standard input, you will receive an integer n – the number of cars that you can obtain. On the next n lines, the cars themselves will follow with their mileage and fuel available, separated by "|" in the following format:
            //"{car}|{mileage}|{fuel}"

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                //Variable for car data
                var input = Console.ReadLine().Split("|"
                    , StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                cars.Add(model, new Car(model, mileage, fuel));
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                var tokens = command.Split(" : "
                    , StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Drive":
                        Drive(cars, tokens);
                        break;
                    case "Refuel":
                        Refuel(cars, tokens);
                        break;
                    case "Revert":
                        Revert(cars, tokens);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("", 
                cars.Select(car => $"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.\n")));

        }

        public static void Revert(Dictionary<string, Car> cars, string[] tokens)
        {
            //•	"Revert : {car} : {kilometers}":
            //o Decrease the mileage of the given car with the given kilometers and print the kilometers you have decreased it with in the following format:
            //"{car} mileage decreased by {amount reverted} kilometers"
            string model = tokens[1];
            int kms = int.Parse(tokens[2]);

            cars[model].Mileage -= kms;

            if (cars[model].Mileage < 10000)
            {
                cars[model].Mileage = 10000;
            }

            Console.WriteLine($"{model} mileage decreased by {kms} kilometers");
            //o If the mileage becomes less than 10 000km after it is decreased, just set it to 10 000km and
            //DO NOT print anything.

        }

        public static void Refuel(Dictionary<string, Car> cars, string[] tokens)
        {
            const int TANK_CAPACITY = 75;
            string model = tokens[1];
            //fuel to be refilled
            int fuel = int.Parse(tokens[2]);

            if (fuel + cars[model].Fuel > TANK_CAPACITY)
            {
                fuel = TANK_CAPACITY - cars[model].Fuel;
            }

            cars[model].Fuel += fuel;

            Console.WriteLine($"{model} refueled with {fuel} liters");
        }

        public static void Drive(Dictionary<string, Car> cars, string[] tokens)
        {
            //variable for fuel consumption
            string model = tokens[1];
            int distance = int.Parse(tokens[2]);
            int fuel = int.Parse(tokens[3]);

            if (fuel > cars[model].Fuel)
            {
                Console.WriteLine($"Not enough fuel to make that ride");
            }
            else
            {
                cars[model].Fuel -= fuel;
                cars[model].Mileage += distance;

                Console.WriteLine($"{model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                if (cars[model].Mileage > 100000)
                {
                    cars.Remove(model);
                    Console.WriteLine($"Time to sell the {model}!");
                }
            }
        }
    }
    class Car
    {
        public Car(string model, int mileage, int fuel)
        {
            Model = model;
            Mileage = mileage;
            Fuel = fuel;
        }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public int Fuel { get; set; }
    }
}
