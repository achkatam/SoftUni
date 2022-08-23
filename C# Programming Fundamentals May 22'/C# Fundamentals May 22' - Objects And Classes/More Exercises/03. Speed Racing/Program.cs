using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your task is to implement a program that keeps track of cars and their fuel and supports methods for moving the cars.. A Car’s model is unique - there will never be 2 cars with the same model.

            //Create list of cars, so we can store them
            var cars = new List<Car>();

            // On the first line of the input, you will receive a number N – the number of cars you need to track. All cars start at 0 kilometers traveled.
            //number of cars to be tracked
            int numOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCars; i++)
            {
                // On each of the next N lines you will receive information about cars in the following format "<Model> <FuelAmount> <FuelConsumptionFor1km>".
                var data = Console.ReadLine().Split();
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelPerKm = double.Parse(data[2]);

                //Create a new and store it in the list
                var car = new Car(model, fuelAmount, fuelPerKm);
                cars.Add(car);
            }

            //After the N lines, until the command "End" is received, you will receive commands in the following format "Drive <CarModel> <amountOfKm>". 
            var command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (command[0] == "Drive")
                {
                    string model = command[1];
                    int kmTraveled = int.Parse(command[2]);

                    var car = cars.FirstOrDefault(c => c.Model == model);
                    car.CalculateTheRange(kmTraveled);

                }
                command = Console.ReadLine().Split();
            }
            //After the "End" command is received, print each car, its current fuel amount and the traveled distance in the format "<Model> <fuelAmount> <distanceTraveled>". Print the fuel amount rounded to two digits after the decimal separator.

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
    // Define a class Car that keeps a track of a car’s model, fuel amount, fuel consumption per kilometer, and traveled distance
    class Car
    {
        public Car(string model, double fuelAmount, double fuelPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelPerKM = fuelPerKm;
            TraveledDistance = 0;// Each car start at 0 kms traveled
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKM { get; set; }
        public int TraveledDistance { get; set; }
        public override string ToString() => $"{Model} {FuelAmount:f2} {TraveledDistance}";
        
        //Implement a method in the Car class to calculate whether or not a car can move that distance. If it can, the car’s fuel amount should be reduced by the amount of used fuel and its traveled distance should be increased by the number of the traveled kilometers. Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same) and you should print on the console "Insufficient fuel for the drive".
        public void CalculateTheRange(int distance)
        {
            double fuelNeeded = FuelPerKM * distance;

            if (fuelNeeded > FuelAmount)
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
            else
            {
                FuelAmount -= fuelNeeded;
                TraveledDistance += distance;
            }
        }
    }
}
