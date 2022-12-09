using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Fish
{
    public class SaltwaterFish : Fish
    {
        private const int IncreaseSize = 2;

        public SaltwaterFish(string name, string species, decimal price)
            : base(name, species, price)
        {
            this.Size = 5;
        }

        public override void Eat()
            => this.Size += IncreaseSize;
    }
}
