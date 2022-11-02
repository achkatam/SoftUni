using Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Baby : IFeedable
    {
        public int Dose { get; set; }

        public FoodType FoodType { get; set; }

        public void Eat()
        {
            Console.WriteLine("Mrun");
        }
    }
}
