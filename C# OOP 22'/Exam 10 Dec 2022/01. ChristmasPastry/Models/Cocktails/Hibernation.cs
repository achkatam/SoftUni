namespace ChristmasPastryShop.Models.Cocktails
{
    public class Hibernation : Cocktail
    {
        private const double DEFAULT_LARGE_INITIAL_PRICE = 10.50;

        public Hibernation(string name, string size)
            : base(name, size, DEFAULT_LARGE_INITIAL_PRICE)
        {
        }
    }
}
