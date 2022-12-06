namespace Gym.Models.Athletes
{
    using Gym.Utilities.Messages;
    using System;


    public class Weightlifter : Athlete
    {
        private const int INITIALSTAMINA = 50;
        private const int INCREASE_STAMINA = 10;
        public Weightlifter(string fullName, string motivation, int numberOfMedals) 
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
