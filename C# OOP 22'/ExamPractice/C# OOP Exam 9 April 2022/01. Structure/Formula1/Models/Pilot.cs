namespace Formula1.Models
{
    using System;
    using System.Text;
    using Formula1.Models.Contracts;
    using Formula1.Utilities;

    public class Pilot : IPilot
    {
        private int numberOfWins;
        private string fullName;

        private bool canRace;
        private IFormulaOneCar car;

        public Pilot(string fullName)
        {
            this.FullName = fullName;
        }

        public string FullName
        {
            get { return fullName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidPilot, value));

                this.fullName = value;
            }
        }


        public IFormulaOneCar Car
        {
            get { return car; }
            private set
            {

                if (value == null)
                    throw new NullReferenceException(string.Format(ExceptionMessages.InvalidCarForPilot));

                car = value;
            }
        }

        public int NumberOfWins
        {
            get { return numberOfWins; }
            private set { numberOfWins = value; }
        }



        public bool CanRace
        {
            get { return canRace; }
            private set { canRace = value; }
        }


        public void AddCar(IFormulaOneCar car)
        {
            this.Car = car;
            this.CanRace = true;
        }

        public void WinRace()
            => this.NumberOfWins++;

        public override string ToString() => $"Pilot {this.fullName} has {this.NumberOfWins} wins.";
    }
}
