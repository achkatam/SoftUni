namespace Vehicles.Models
{

    using Contracts;
    using Exceptions;


    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumption, double fuelConsumptionIncrement)
        {
            this.FuelQuantity = fuelQuantity;
            //the counsumption increses coused by using the AC
            this.FuelConsumption = fuelConsumption + fuelConsumptionIncrement;
        }

        public double FuelQuantity { get; private set; }

        public double FuelConsumption { get; private set; }

        public string Drive(double distance)
        {
            double neededFuel = distance * this.FuelConsumption;
            if (neededFuel > this.FuelQuantity)
            {
            //not enough fuel
                throw new InsufficientFuelException
                    (string.Format(ExceptionMessage.InsufficientFuelExceptionMessage, this.GetType().Name));
            }

            this.FuelQuantity -= neededFuel;

            return $"{this.GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            this.FuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
