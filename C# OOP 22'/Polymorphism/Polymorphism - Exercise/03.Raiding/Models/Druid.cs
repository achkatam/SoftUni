namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        {

        }

        public override int Power => 80;

        public override string CastAbility()
            => base.CastAbility() + $"healed for {this.Power}";
    }
}
