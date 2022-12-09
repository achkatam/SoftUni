using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets.Contracts;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            var validAstronauts = astronauts.Where(x => x.CanBreath).ToList();



            foreach (var astronaut in validAstronauts)
            {
                while (planet.Items.Any())
                {

                    astronaut.Bag.Items.Add(planet.Items.First());
                    planet.Items.Remove(planet.Items.First());
                    astronaut.Breath();

                    if (!astronaut.CanBreath)
                    {
                        break;
                    }

                    //if (planet.Items.Count == 0)
                    //    break;
                }
            }

        }
    }
}
