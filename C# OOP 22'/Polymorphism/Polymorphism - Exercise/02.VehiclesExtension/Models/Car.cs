namespace Vehicles.Models
{

    public class Car : Vehicle
    {
        private const double FuelConsumptionIncrement = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption = fuelConsumption + FuelConsumptionIncrement;
        }
    }
}
