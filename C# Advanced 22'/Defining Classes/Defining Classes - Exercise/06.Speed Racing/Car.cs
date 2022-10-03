using System;
namespace _06.Speed_Racing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelPerKm;
            TravelledDistance = 0;
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public override string ToString() => $"{Model} {FuelAmount:f2} {TravelledDistance}";

        public void Drive(double distance)
        {
            //Implement a method in the Car class to calculate whether or not a car can move that distance. If it can, the car’s fuel amount should be reduced by the amount of used fuel and its traveled distance should be increased by the number of the traveled kilometers. Otherwise, the car should not move (its fuel amount and the traveled distance should stay the same) and you should print on the console:
            //"Insufficient fuel for the drive"

            double fuelNeeded = FuelConsumptionPerKilometer * distance;

            if (fuelNeeded > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");

                return;
            }

            FuelAmount -= fuelNeeded;
            TravelledDistance += distance;
        }
    }
}
