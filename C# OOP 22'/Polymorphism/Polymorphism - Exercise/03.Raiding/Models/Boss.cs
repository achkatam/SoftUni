namespace Raiding.Models
{

    public class Boss
    {
        private int hp;

        public Boss(int hp)
        {
            this.Hp = hp;
        }

        public int Hp { get; set; }
    }
}
