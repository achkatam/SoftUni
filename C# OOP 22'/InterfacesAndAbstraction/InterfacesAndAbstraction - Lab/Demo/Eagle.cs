using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Eagle : Animal
    {
        public Eagle() : base(FoodType.Oats, 10) { }
        
        public void Fly()
        {
            Console.WriteLine("I do fly");
        }
    }
}
