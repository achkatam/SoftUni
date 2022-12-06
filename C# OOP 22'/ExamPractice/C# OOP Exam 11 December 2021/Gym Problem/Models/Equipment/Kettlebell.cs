namespace Gym.Models.Equipment
{ 

    public class Kettlebell : Equipment
    {
        private const double INITIALWEIGHT = 10000;
        private const decimal INITIALPRICE = 80;
        public Kettlebell() : base(INITIALWEIGHT, INITIALPRICE)
        {
        }
    }
}
