namespace Raiding.Models
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name)
        {
        }

        public override int Power => 100;

        public override string CastAbility()
            => base.CastAbility() + $"healed for {this.Power}";
    }
}
