using System.Reflection.Metadata.Ecma335;
using Vehicles.Exceptions;

namespace Vehicles.Models
{


    public class Truck : Vehicle
    {
        private const double FuelConsumptionIncrement = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption = fuelConsumption + FuelConsumptionIncrement;
        }

        public override void Refuel(double liters)
        {
            if (this.FuelQuantity + liters > this.TankCapacity)
            {
                throw new OverfillingTheTank(
                    string.Format(ExceptionMessage.OVERFILLING_THE_TANK, liters));
            }

            //there's a hole in the tank and keeps only 95% of the full tank capacity
            base.Refuel(liters * 0.95);
        }
    }
}
