namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;

    using Foods;

    public class Cat : Feline
    {
        private const double CAT_WEIGHT_MULTIPLIER = 0.3;

        public Cat(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        public override IReadOnlyCollection<Type> PrefferedFoods
            => new HashSet<Type>() { typeof(Meat), typeof(Vegetable) };

        protected override double WeightMultiplier
            => CAT_WEIGHT_MULTIPLIER;

        public override string ProduceSound() => "Meow";
    }
}
