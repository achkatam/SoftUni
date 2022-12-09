using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int INITIALCOMFORT = 5;
        private const int INITIAL_PRICE = 10;
        public Plant() 
            : base(INITIALCOMFORT, INITIAL_PRICE)
        {
        }
    }
}
