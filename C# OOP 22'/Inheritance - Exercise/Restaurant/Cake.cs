namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double CAKE_CALORIES = 1000;
        private const double CAKE_GRAMS = 200;
        private const decimal CAKE_PRICE = 5;

        public Cake(string name) : base(name, CAKE_PRICE, CAKE_GRAMS, CAKE_CALORIES)
        {

        }

    }
}
