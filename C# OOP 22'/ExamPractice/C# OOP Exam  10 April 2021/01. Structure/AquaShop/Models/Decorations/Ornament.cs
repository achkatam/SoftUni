using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        private const int INITIALCOMFORT = 1;
        private const int INITIAL_PRICE = 5;

        public Ornament() 
            : base(INITIALCOMFORT, INITIAL_PRICE)
        {
        }
    }
}
