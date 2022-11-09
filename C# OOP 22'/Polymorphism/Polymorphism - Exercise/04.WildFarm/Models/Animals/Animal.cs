namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using WildFarm.Exceptions;

    public abstract class Animal : IAnimal
    {
        private Animal()
        {
            this.FoodEaten = 0;
        }

        protected Animal(string name, double weight) : this()
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        protected abstract double WeightMultiplier { get; }

        public abstract IReadOnlyCollection<Type> PrefferedFoods { get; }

        public abstract string ProduceSound();

        public void Eat(IFood food)
        {
            if (!this.PrefferedFoods.Any(t => food.GetType().Name == t.Name))
            {
                throw new FoodNotEatenException(string.Format
                    (ExceptionMessages.FoodNotEatenExpectionMessage, this.GetType().Name, food.GetType().Name));
            }

            this.Weight += food.Quantity * WeightMultiplier;
            this.FoodEaten += food.Quantity;
        }

        public override string ToString() => $"{this.GetType().Name} [{this.Name}, ";
    }
}
