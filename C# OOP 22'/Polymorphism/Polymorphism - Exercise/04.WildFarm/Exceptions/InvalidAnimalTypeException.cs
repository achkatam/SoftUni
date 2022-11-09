namespace WildFarm.Exceptions
{
    using System;


    public class InvalidAnimalTypeException : Exception
    {
        private const string DEFAULT_MESSAGE = "Invalid animal type!";

        public InvalidAnimalTypeException() : base(DEFAULT_MESSAGE)
        {

        }

        public InvalidAnimalTypeException(string message) : base(message)
        {

        }
    }
}
