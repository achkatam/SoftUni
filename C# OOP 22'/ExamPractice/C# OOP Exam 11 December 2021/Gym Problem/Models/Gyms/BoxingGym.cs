namespace Gym.Models.Gyms
{ 
    public class BoxingGym : Gym
    {
        private const int INITIALCAPACITY = 15;
        public BoxingGym(string name) 
            : base(name, INITIALCAPACITY)
        {

        }
    }
}
