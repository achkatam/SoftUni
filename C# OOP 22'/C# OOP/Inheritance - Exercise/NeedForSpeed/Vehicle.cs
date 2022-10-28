using System;
using System.Reflection.Metadata.Ecma335;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public int MyProperty { get; set; }
        public virtual double FuelConsumption => DEFAULT_FUEL_CONSUMPTION;

        public void Drive(double kilometers)
        {
            double fuelLeft = Fuel - FuelConsumption * kilometers;

            if (fuelLeft >= 0)
                Fuel -= FuelConsumption * kilometers;
        }
    }
}
