using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class FreshwaterFish : Fish
    {
        private const int IncreaseSize = 3;
        public FreshwaterFish(string name, string species, decimal price) 
            : base(name, species, price)
        {
            this.Size = 3;
        }

        public override void Eat()
            => this.Size += IncreaseSize;
    }
}
