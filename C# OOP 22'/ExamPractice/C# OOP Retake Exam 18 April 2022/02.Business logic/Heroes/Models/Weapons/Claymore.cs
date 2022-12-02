namespace Heroes.Models.Weapons
{

    public class Claymore : Weapon
    {
        private const int DAMAGE = 20;

        public Claymore(string name, int durability)
            : base(name, durability)
        {
        }

        public override int DoDamage()
        {
            if (this.Durability > 0)
                return DAMAGE;

            return 0;
        }
    }
}
