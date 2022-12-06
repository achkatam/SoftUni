namespace Gym.Models.Gyms
{

    public class WeightliftingGym : Gym
    {
        private const int INITIALCAPACITY = 20;

        public WeightliftingGym(string name)
            : base(name, INITIALCAPACITY)
        {

        }
    }
}
