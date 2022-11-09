namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;

    using Foods;

    public class Dog : Mammal
    {
        private const double DOG_WEIGHT_MULTIPLIER = 0.4;


        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type>() { typeof(Meat) };

        protected override double WeightMultiplier
            => DOG_WEIGHT_MULTIPLIER;

        public override string ProduceSound() => "Woof!";

        public override string ToString()
        {
            return base.ToString() + $"{this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
