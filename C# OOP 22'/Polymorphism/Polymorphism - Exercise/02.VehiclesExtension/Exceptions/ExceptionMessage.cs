namespace Vehicles.Exceptions
{

    public static class ExceptionMessage
    {
        public const string InsufficientFuelExceptionMessage
            = "{0} needs refueling";

        public const string WRONG_FUEL_INPUT
            = "Fuel must be a positive number";

        public const string OVERFILLING_THE_TANK
            = "Cannot fit {0} fuel in the tank";
    }
}
