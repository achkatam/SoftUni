namespace PlanetWars.Models.MilitaryUnits
{
    using PlanetWars.Models.MilitaryUnits.Contracts;
    using PlanetWars.Utilities.Messages;
    using System;

    public abstract class MilitaryUnit : IMilitaryUnit
    {
        private double cost;
        private int enduranceLevel;

        protected MilitaryUnit(double cost)
        {
            this.Cost = cost;
            this.EnduranceLevel = 1;
        }

        public double Cost
        {
            get => this.cost;
            private set => this.cost = value;
        }

        public int EnduranceLevel
        {
            get => this.enduranceLevel;
            private set => this.enduranceLevel = value;
        }

        public void IncreaseEndurance()
        {
            if (this.EnduranceLevel == 20)
            {
                throw new ArgumentException(ExceptionMessages.EnduranceLevelExceeded);
            }

            this.EnduranceLevel++;
        }
    }
}
