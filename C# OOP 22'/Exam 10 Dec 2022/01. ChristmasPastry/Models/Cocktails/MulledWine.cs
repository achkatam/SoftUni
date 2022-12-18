namespace ChristmasPastryShop.Models.Cocktails
{
    using System.Runtime.CompilerServices;

    public class MulledWine : Cocktail
    {
        private const double DEFAULT_LARGE_INITIAL_PRICE = 13.50;

        public MulledWine(string name, string size) 
            :  base(name, size, DEFAULT_LARGE_INITIAL_PRICE)
        {
        } 
    }
}
