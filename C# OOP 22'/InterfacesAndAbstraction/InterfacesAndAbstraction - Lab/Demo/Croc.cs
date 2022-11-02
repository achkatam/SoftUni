using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Croc : Animal
    {
        public Croc() : base(FoodType.Meat, 80) { }
        

        public void Scare()
        {
            Console.WriteLine("I scare people");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat a lot...");
        } 
    }
}
