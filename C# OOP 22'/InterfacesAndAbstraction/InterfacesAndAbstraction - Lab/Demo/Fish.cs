using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Fish : Animal
    {
        public Fish() : base(FoodType.Wheat, 5) { }
        
        public void Swim()
        {
            Console.WriteLine("I can swim");
        }
    }
}
