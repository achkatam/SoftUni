using Heroes.Models.Contracts;
using Heroes.Models.Heroes;
using System.Collections.Generic;
using System.Linq;

namespace Heroes.Models.Map
{
    public class Map : IMap
    {
        public string Fight(ICollection<IHero> players)
        {
            List<IHero> knights = players.Where(x => GetType() == typeof(Knight)).ToList();
            List<IHero> barbarians = players.Where(x => GetType() == typeof(Barbarian)).ToList();

            int counter = 1;
            while (knights.Any(x => x.IsAlive == true) && barbarians.Any(x => x.IsAlive == true))
            {
                if (counter % 2 != 0)
                {
                    foreach (var knight in knights.Where(x => x.IsAlive))
                    {
                        for (int i = 0; i < barbarians.Count; i++)
                        {
                            barbarians[i].TakeDamage(knight.Weapon.DoDamage());
                        }
                    }
                }
                else
                {
                    foreach (var barbarian in barbarians.Where(x => x.IsAlive))
                    {
                        for (int i = 0; i < knights.Count; i++)
                        {
                            knights[i].TakeDamage(barbarian.Weapon.DoDamage());
                        }
                    }
                }
            }

            if (knights.Any(x => x.IsAlive == true))
            {
                return $"The knights took {knights.Count(x => x.IsAlive == false)} casualties but won the battle.";
            }
            else if (barbarians.Any(x => x.IsAlive) == true)
            {
                return $"The barbarians took {barbarians.Count(x => x.IsAlive == false)} casualties but won the battle.";
            }

            return null;
        }
    }
}
