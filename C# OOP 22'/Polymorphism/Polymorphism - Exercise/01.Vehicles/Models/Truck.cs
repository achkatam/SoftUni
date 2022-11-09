namespace Vehicles.Models
{


    public class Truck : Vehicle
    {
        private const double FuelConsumptionIncrement = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption, FuelConsumptionIncrement)
        {

        }

        public override void Refuel(double liters)
        {
            //there's a hole in the tank and keeps only 95% of the full tank capacity
            base.Refuel(liters * 0.95);
        }
    }
}
