namespace Vehicles.Exceptions
{
using System;

    internal class WrongFuelInput : Exception
    {
        public WrongFuelInput()
        {
        }

        public WrongFuelInput(string message) : base(message)
        {

        }
    }
}
