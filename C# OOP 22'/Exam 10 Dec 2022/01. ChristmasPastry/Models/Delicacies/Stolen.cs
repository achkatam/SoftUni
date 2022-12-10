namespace ChristmasPastryShop.Models.Delicacies
{
    public class Stolen : Delicacy
    {
        private const double DEFAULT_INITIAL_PRICE = 3.50;

        public Stolen(string name) 
            : base(name, DEFAULT_INITIAL_PRICE)
        {
        }
    }
}
