namespace PrototypePattern.Models
{
    using System;

    public class Sandwich : SandwichPrototype
    {
        private string bread;
        private string meat;
        private string cheese;
        private string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            Console.WriteLine($"Cloning sandwich with ingredients: {this.GetIngredientsList()}");

           return this.MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientsList()
            => $"{this.bread}, {this.meat}, {this.cheese}, {this.veggies}";
    }
}
