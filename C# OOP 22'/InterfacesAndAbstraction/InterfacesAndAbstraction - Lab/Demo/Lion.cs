using Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Lion : IFeedable
    {
        public int Dose { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public FoodType FoodType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Eat()
        {

        }
    }
}
