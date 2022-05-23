using System;

namespace Abstract_Class_And_Attributes
{
    class Program
    {
        abstract class Vehicle
        {
            public abstract void Move();
            public void GetDesciption()
            {
                Console.WriteLine($"Vehicles are used for transportation.");
            }
        }
        class Bicycle : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine($"The bicycle pedals forward");
            }
        }
        class Plane : Vehicle
        {
            public override void Move()
            {
                Console.WriteLine($"The plane  flies through the sky");
            }
        }
        static void Main(string[] args)
        {
            //A B S T R A C T C L A S S   A N D    A T T R I B U T E S
            Plane myPlane = new Plane();
            myPlane.Move();
            Console.WriteLine();
            myPlane.GetDesciption();
            Console.ReadLine();
        }
    }
}
