namespace Formula1.Models
{
    using Formula1.Models.Contracts;
    using Formula1.Utilities;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Race : IRace
    {

        private string raceName;
        private int numberOfLaps;
        private bool tookPlace;
        private ICollection<IPilot> pilots;

        public Race(string raceName, int numberOfLaps)
        {
            this.RaceName = raceName;
            this.NumberOfLaps = numberOfLaps;
            this.pilots = new List<IPilot>();
        }

        public string RaceName
        {
            get { return raceName; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidRaceName, value));

                this.raceName = value;
            }
        }

        public int NumberOfLaps
        {
            get { return numberOfLaps; }
            private set
            {
                if (value < 1)
                    throw new ArgumentException(string.Format(ExceptionMessages.InvalidLapNumbers, value));

                this.numberOfLaps = value;
            }
        }

        public bool TookPlace
        {
            get { return tookPlace; }
            set { tookPlace = value; }
        }


        public ICollection<IPilot> Pilots => this.pilots;

        public void AddPilot(IPilot pilot) => this.Pilots.Add(pilot);

        public string RaceInfo()
        {

            var sb = new StringBuilder();


            sb
            .AppendLine($"The {this.raceName} race has:")
            .AppendLine($"Participants: {this.pilots.Count}")
           .AppendLine($"Number of laps: {this.numberOfLaps}")
           .AppendLine($"Took place: {this.TookPlace}");

            return sb.ToString().Trim();
        }
    }
}
