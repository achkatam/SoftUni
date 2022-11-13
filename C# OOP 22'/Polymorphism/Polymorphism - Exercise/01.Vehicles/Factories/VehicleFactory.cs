namespace Vehicles.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

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
            //using reflection

            var vehicle = Assembly.GetExecutingAssembly()
                .GetTypes().Where(t => typeof(IVehicle).IsAssignableFrom(t)
                && t.Name.StartsWith(type)).FirstOrDefault();

            return (IVehicle)Activator.CreateInstance(vehicle, new object[] {  fuelQnty, fuelConsumption });
        }
    }
}
