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

        public IVehicle CreateVehicle(string type, double fuelQnty, double fuelConsumption)
        {
            IVehicle vehicle;
            if (type == "Car")
                vehicle = new Car(fuelQnty, fuelConsumption);
            else if (type == "Truck")
                vehicle = new Truck(fuelQnty, fuelConsumption);
            else
                throw new InvalidVehicleTypeException();
            
            return vehicle;
        }
    }
}
