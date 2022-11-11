namespace Vehicles.Factories
{
    using Vehicles.Exceptions;
    using Vehicles.Factories.Contracts;
    using Vehicles.Models;
    using Vehicles.Models.Contracts;

    public class VehicleFactory : IVehicleFactory
    {
        public VehicleFactory()
        {

        }

        public IVehicle CreateVehicle(string type, double fuelQnty, double fuelConsumption, double tankCapacity)
        {
            IVehicle vehicle;
            if (type == "Car")
                vehicle = new Car(fuelQnty, fuelConsumption, tankCapacity);
            else if (type == "Truck")
                vehicle = new Truck(fuelQnty, fuelConsumption, tankCapacity);
            else if (type == "Bus")
                vehicle = new Bus(fuelQnty, fuelConsumption, tankCapacity);
            else
                throw new InvalidVehicleTypeException();
            
            return vehicle;
        }
    }
}
