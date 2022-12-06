namespace Gym.Models.Equipment
{ 
    public class BoxingGloves : Equipment
    {
        private const double INITIALWEIGHT = 227;
        private const decimal INITIALPRICE = 120;

        public BoxingGloves() : base(INITIALWEIGHT, INITIALPRICE)
        {
        }
    }
}
