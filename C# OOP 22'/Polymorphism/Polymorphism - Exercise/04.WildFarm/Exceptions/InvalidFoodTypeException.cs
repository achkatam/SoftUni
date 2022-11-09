namespace WildFarm.Exceptions
{
using System;


    public class InvalidFoodTypeException : Exception
    {
        private const string DEFAULT_MESSAGE = "Invalid food type!";

        public InvalidFoodTypeException() : base(DEFAULT_MESSAGE)
        {
        }

        public InvalidFoodTypeException(string message) : base(message)
        {

        }
    }
}
