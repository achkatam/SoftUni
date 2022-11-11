namespace Vehicles.Exceptions
{
using System;

    public class OverfillingTheTank : Exception
    {
        public OverfillingTheTank()
        {
        }

        public OverfillingTheTank(string message):base(message)
        {

        }
    }
}
