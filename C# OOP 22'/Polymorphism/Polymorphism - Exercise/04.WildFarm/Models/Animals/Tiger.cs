namespace WildFarm.Models.Animals
{
    using System;
    using System.Collections.Generic;

    using Foods;

    public class Tiger : Feline
    {
        private const double TIGER_WEIGHT_MULTIPLIER = 1;


        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override IReadOnlyCollection<Type> PrefferedFoods =>
            new HashSet<Type>() { typeof(Meat) };

        protected override double WeightMultiplier
            => TIGER_WEIGHT_MULTIPLIER;

        public override string ProduceSound() => "ROAR!!!";
    }
}
