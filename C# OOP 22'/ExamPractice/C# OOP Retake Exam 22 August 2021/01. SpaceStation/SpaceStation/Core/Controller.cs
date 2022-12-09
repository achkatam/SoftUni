using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories;
using SpaceStation.Repositories.Contracts;
using SpaceStation.Utilities.Messages;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IPlanet> planets;
        private readonly IRepository<IAstronaut> astronauts;
        private int exploredPlanets;

        public Controller()
        {
            this.planets = new PlanetRepository();
            this.astronauts = new AstronautRepository();
        }
        public string AddAstronaut(string type, string astronautName)
        {
            IAstronaut astronaut = null;

            switch (type)
            {
                case "Biologist":
                    astronaut = new Biologist(astronautName);
                    break;
                case "Geodesist":
                    astronaut = new Geodesist(astronautName);
                    break;
                case "Meteorologist":
                    astronaut = new Meteorologist(astronautName);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidAstronautType);
            }

            this.astronauts.Add(astronaut);

            return string.Format(OutputMessages.AstronautAdded, type, astronautName);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            IPlanet planet = new Planet(planetName);

            foreach (var item in items)
            {
                planet.Items.Add(item);
            }
            this.planets.Add(planet);

            return string.Format(OutputMessages.PlanetAdded, planetName);
        }

        public string RetireAstronaut(string astronautName)
        {
            IAstronaut astronaut = this.astronauts.FindByName(astronautName);

            if (astronaut == null)
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));

            this.astronauts.Remove(astronaut);

            return string.Format(OutputMessages.AstronautRetired, astronautName);
        }
        public string ExplorePlanet(string planetName)
        {
            var astronauts = this.astronauts.Models.Where(x => x.Oxygen > 60).ToList();

            if (!astronauts.Any())
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);

            IMission mission = new Mission();
            IPlanet planet = this.planets.FindByName(planetName);

            mission.Explore(planet, astronauts);
            this.exploredPlanets++;

            return string.Format(OutputMessages.PlanetExplored, planetName, astronauts.Where(x => 
            !x.CanBreath).Count());
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"{this.exploredPlanets} planets were explored!")
                .AppendLine($"Astronauts info:");

            foreach (var astronaut in this.astronauts.Models)
            {
                string bagOutput = astronaut.Bag.Items.Any() ? $"{string.Join(", ", astronaut.Bag.Items)}"
                    : "none";

                sb
                    .AppendLine($"Name: {astronaut.Name}")
                    .AppendLine($"Oxygen: {astronaut.Oxygen}")
                    .AppendLine($"Bag items: {bagOutput}");
            }

            return sb.ToString().TrimEnd();
        }


    }
}
