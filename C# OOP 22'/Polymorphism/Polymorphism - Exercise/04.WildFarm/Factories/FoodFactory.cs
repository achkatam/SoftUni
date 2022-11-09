﻿namespace Factories
{

    using WildFarm.Exceptions;
    using WildFarm.Factories.Contracts;
    using WildFarm.Models.Contracts;
    using WildFarm.Models.Foods;

    public class FoodFactory : IFoodFactory
    {
        public IFood CreateFood(string type, int quantity)
        {
            IFood food;

            if (type == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else if (type == "Fruit")
            {
                food = new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                food = new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                food = new Seeds(quantity);
            }
            else
            {
                throw new InvalidFoodTypeException();
            }

            return food;
        }
    }
}
