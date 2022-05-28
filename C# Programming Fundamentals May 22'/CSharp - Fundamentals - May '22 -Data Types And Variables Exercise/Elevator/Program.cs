using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p persons. The input 
            //holds two lines: the number of people n and the capacity p of the elevator.

            //input
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double remainingCourses = (double)people / capacity;

            Console.WriteLine(Math.Ceiling(remainingCourses));

        }
    }
}
