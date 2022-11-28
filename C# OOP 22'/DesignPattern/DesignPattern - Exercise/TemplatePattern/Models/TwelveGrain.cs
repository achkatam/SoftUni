namespace TemplatePattern.Models
{
    using System;

    public class TwelveGrain : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine($"Gatherin ingredients for 12-Grain Bread.");
        }
        public override void Bake()
        {
            Console.WriteLine($"Baking the 12-Grain Bread. (25 minutes)");
        }
    }
}
