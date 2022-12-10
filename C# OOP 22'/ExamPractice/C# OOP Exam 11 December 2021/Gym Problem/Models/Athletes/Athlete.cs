﻿namespace Gym.Models.Athletes
{
    using System;

    using Gym.Models.Athletes.Contracts;
    using Gym.Utilities.Messages;

    public abstract class Athlete : IAthlete
    {
        private string fullName;
        private string motivation;
        private int numberOfMedals;

        protected Athlete(string fullName, string motivation, int stamina, int numberOfMedals)
        {
            this.FullName = fullName;
            this.Motivation = motivation;
            this.Stamina = stamina;
            this.NumberOfMedals = numberOfMedals;
        }

        public string FullName
        {
            get => this.fullName;
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(ExceptionMessages.InvalidAthleteName);

                this.fullName = value;
            }
        }

        public string Motivation
        {
            get => this.motivation;
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException(ExceptionMessages.InvalidAthleteMotivation);

                this.motivation = value;
            }
        }

        public int Stamina { get; protected set; }

        public int NumberOfMedals
        {
            get => this.numberOfMedals;
            private set
            {
                if (value < 0)
                    throw new ArgumentException(ExceptionMessages.InvalidAthleteMedals);

                this.numberOfMedals = value;
            }
        }

        public abstract void Exercise();
    }
}