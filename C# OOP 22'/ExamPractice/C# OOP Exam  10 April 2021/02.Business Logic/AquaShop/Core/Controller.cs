using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Repositories.Contracts;
using AquaShop.Utilities.Messages;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private IRepository<IDecoration> decorations;
        private ICollection<IAquarium> tanks;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.tanks = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium tank = null;

            switch (aquariumType)
            {
                case "FreshwaterAquarium":
                    tank = new FreshwaterAquarium(aquariumName);
                    break;
                case "SaltwaterAquarium":
                    tank = new SaltwaterAquarium(aquariumName);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }

            this.tanks.Add(tank);

            return string.Format(OutputMessages.SuccessfullyAdded, aquariumType);
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration = null;

            switch (decorationType)
            {
                case "Ornament":
                    decoration = new Ornament();
                    break;
                case "Plant":
                    decoration = new Plant();
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            this.decorations.Add(decoration);


            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            IAquarium tank = this.tanks.FirstOrDefault(x => x.Name == aquariumName);

            IDecoration decoration = this.decorations.FindByType(decorationType);

            if (decoration == null)
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));

            tank.AddDecoration(decoration);
            this.decorations.Remove(decoration);

            return string.Format(OutputMessages.EntityAddedToAquarium, decorationType, aquariumName);
        }
        public string AddFish(string aquariumName, string fishType, string fishName, string fishSpecies, decimal price)
        {
            IFish fish = null;

            switch (fishType)
            {
                case "FreshwaterFish":
                    fish = new FreshwaterFish(fishName, fishSpecies, price);
                    break;
                case "SaltwaterFish":
                    fish = new SaltwaterFish(fishName, fishSpecies, price);
                    break;
                default:
                    throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }

            IAquarium tank = this.tanks.FirstOrDefault(x => x.Name == aquariumName);

            if (fish.GetType() == typeof(SaltwaterFish) && tank.GetType().Name == "FreshwaterAquarium"
                || fish.GetType() == typeof(FreshwaterFish) && tank.GetType().Name == "SaltwaterAquarium")
            {
                return OutputMessages.UnsuitableWater;
            }

            tank.AddFish(fish);
            return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium tank = this.tanks.FirstOrDefault(x => x.Name == aquariumName);

            tank.Feed();

            return string.Format(OutputMessages.FishFed, tank.Fish.Count);
        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium tank = this.tanks.FirstOrDefault(x => x.Name == aquariumName);

            decimal totalValue = tank.Fish.Sum(x => x.Price) + tank.Decorations.Sum(x => x.Price);

            return string.Format(OutputMessages.AquariumValue, aquariumName, totalValue);
        }


        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var tank in this.tanks)
            {
                sb.AppendLine(tank.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
