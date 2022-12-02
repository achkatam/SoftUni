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
            List<IHero> knights = players.Where(x => x.GetType() == typeof(Knight)).ToList();
            List<IHero> barbarians = players.Where(x => x.GetType() == typeof(Barbarian)).ToList();

            int counter = 1;
            while (knights.Any(x => x.IsAlive) && barbarians.Any(x => x.IsAlive))
            {
                if (counter % 2 != 0)
                {
                    foreach (var knight in knights.Where(x => x.IsAlive))
                    {
                        foreach (var barbarian in barbarians.Where(x => x.IsAlive))
                        {
                            barbarian.TakeDamage(knight.Weapon.DoDamage());
                        }
                    }
                }
                else
                {
                    foreach (var barbarian in barbarians.Where(x => x.IsAlive == true))
                    {
                        foreach (var kngiht in knights.Where(x => x.IsAlive))
                        {
                            kngiht.TakeDamage(barbarian.Weapon.DoDamage());
                        }
                    }
                }

                counter++;
            }

            string output = string.Empty;

            if (knights.Any(x => x.IsAlive))
            {
                output = $"The knights took {knights.Count(x => !x.IsAlive)} casualties but won the battle.";
            }
            else if (barbarians.Any(x => x.IsAlive))
            {
                output = $"The barbarians took {barbarians.Count(x => !x.IsAlive)} casualties but won the battle.";
            }

            return output;
        }
         
    }
}
