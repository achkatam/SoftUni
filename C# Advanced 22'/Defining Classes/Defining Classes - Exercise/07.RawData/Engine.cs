using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
    public class Engine
    {
        //•	Engine: a class with two properties – speed and power
        public Engine(int speed, int power)
        {
           this. Speed = speed;
            this.Power = power;
        }
        public int Speed { get; set; }
        public int Power { get; set; }

    }
}
