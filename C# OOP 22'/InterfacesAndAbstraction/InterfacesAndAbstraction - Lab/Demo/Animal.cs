using Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Animal : IFeedable
    {
        public FoodType FoodType { get; set; }

        public int Dose { get; set; }

        public Animal(FoodType foodType, int dose)
        {
            this.FoodType = foodType;
            this.Dose = dose;
        }

        public virtual void Eat()
        {
            Console.WriteLine("I am eating");
        }

        public void Sleep()
        {
            Console.WriteLine("I am sleeping");
        }

        public void Play()
        {
            Console.WriteLine("I'm playing");
        }
    }
}
