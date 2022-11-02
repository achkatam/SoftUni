namespace _05.FootballTeamGenerator
{
    using System;

    public class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                if (this.InvalidStat(value))
                {
                    throw new ArgumentException
                        (String.Format(ExceptionMessages.InvalidStatistics, nameof(this.Endurance)));
                }

                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            private set
            {
                if (this.InvalidStat(value))
                {
                    throw new ArgumentException
                        (String.Format(ExceptionMessages.InvalidStatistics, nameof(this.Sprint)));
                }

                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                if (this.InvalidStat(value))
                {
                    throw new ArgumentException
                        (String.Format(ExceptionMessages.InvalidStatistics, nameof(this.Dribble)));
                }

                this.dribble = value;
            }
        }

        public int Passing
        {
            get => this.passing;
            private set
            {
                if (this.InvalidStat(value))
                {
                    throw new ArgumentException
                        (String.Format(ExceptionMessages.InvalidStatistics, nameof(this.Passing)));
                }

                this.passing = value;
            }
        }

        public int Shooting
        {
            get => this.shooting;
            private set
            {
                if (this.InvalidStat(value))
                {
                    throw new ArgumentException
                        (String.Format(ExceptionMessages.InvalidStatistics, nameof(this.Shooting)));
                }

                this.shooting = value;
            }
        }

        private bool InvalidStat(int value) => value < 0 || value > 100;
    }
}