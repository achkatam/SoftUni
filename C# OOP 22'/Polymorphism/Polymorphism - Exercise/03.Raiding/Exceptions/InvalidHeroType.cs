namespace Raiding.Exceptions
{
    using System;

    public class InvalidHeroType : Exception
    {
        public InvalidHeroType()
        {

        }

        public InvalidHeroType(string message) : base(message)
        {

        }
    }
}
