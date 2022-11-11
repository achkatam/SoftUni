namespace Vehicles.Exceptions
{
using System;


    public class InvalidVehicleTypeException : Exception
    {
        private const string DefaultMessage
            = "Vehicle type not supported!";

        //Compile-Time polymorphism
        public InvalidVehicleTypeException()
        {

        }

        public InvalidVehicleTypeException(string message) : base()
        {

        }
    }
}
