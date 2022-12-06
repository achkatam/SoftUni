namespace Gym.Models.Athletes
{
    using System;

    using Gym.Utilities.Messages;

    public class Boxer : Athlete
    {
        private const int INITIALSTAMINA = 60;
        private const int INCREASE_STAMINA = 15;
        public Boxer(string fullName, string motivation, int numberOfMedals)
            : base(fullName, motivation, INITIALSTAMINA, numberOfMedals)
        {
        }

        public override void Exercise()
        {
            this.Stamina += INCREASE_STAMINA;

            if (this.Stamina > 100)
            {
                this.Stamina = 100;
                throw new ArgumentException(ExceptionMessages.InvalidStamina);
            }
        }
    }
}
