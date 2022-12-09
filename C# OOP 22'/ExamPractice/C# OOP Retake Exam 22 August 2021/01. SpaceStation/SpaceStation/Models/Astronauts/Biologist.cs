using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        private const double INITIAL_OXYGEN = 70;
        private const double DECREASE_OXYGEN = 5;
        public Biologist(string name) : base(name, INITIAL_OXYGEN)
        {
        }

        public override void Breath()
        {
            this.Oxygen -= 5;

            if (this.Oxygen < 0)
            {
                this.Oxygen = 0;
            }
        }
    }
}
