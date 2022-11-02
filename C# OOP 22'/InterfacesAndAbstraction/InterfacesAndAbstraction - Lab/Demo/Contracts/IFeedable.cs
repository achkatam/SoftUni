using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Contracts
{
    public interface IFeedable
    {
        //what should the implementing class do
        void Eat();

        int Dose { get; set; }

        FoodType FoodType { get; set; }
    }
}
