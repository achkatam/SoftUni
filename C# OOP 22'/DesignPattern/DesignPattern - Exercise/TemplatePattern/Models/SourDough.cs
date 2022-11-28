namespace TemplatePattern.Models
{
    using System;

    public class SourDough : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering ingredients for Sourdough Bread.");
        }
        public override void Bake()
        {
            Console.WriteLine($"Baking the Sourdough bread. (20 minutes)");
        }

       
    }
}
