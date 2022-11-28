namespace BuilderPatternAndFluentPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        public Engine Engine { get; set; }
        public bool Navigaition { get; set; }
        public bool HeatedSeats { get; set; }

        public Car BuildEngine()
        {
            Console.WriteLine("Building engine..");
            Engine = new Engine();

            return this;
        }

        public Car BuildNavigation()
        {
            Console.WriteLine("Building navigation..");
            this.Navigaition = true;

            return this;
        }

        public Car BuildingHeatedSeats()
        {
            Console.WriteLine("Buildning heated seats..");
            this.HeatedSeats = true;
            return this;
        }

      
    }
}
