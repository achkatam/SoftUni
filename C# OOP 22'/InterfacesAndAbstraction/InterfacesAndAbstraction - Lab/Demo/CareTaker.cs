using Demo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class CareTaker 
    {
        public void Feed(IFeedable feedable)
        {
            Console.WriteLine($"Get {feedable.Dose} {feedable.FoodType} from the warehouse");
            Console.WriteLine();
            Console.WriteLine("Feeding animal");
            feedable.Eat();
        }
    }
}
