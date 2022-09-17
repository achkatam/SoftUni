using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Collections;

namespace _10._Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The road Sam is on has a single lane where cars queue up until the light goes green. When it does, they start passing one by one during the green light and the free window before the intersecting road’s light goes green. During one second only one part of a car(a single character) passes the crossroads.If a car is still at the crossroads when the free window ends, it will get hit at the first character that is still in the crossroads.

            //•	On the first line, you will receive the duration of the green light in seconds – an integer in the range [1-100]
            //•	On the second line, you will receive the duration of the free window in seconds – an integer in the range[0 - 100]
            //•	On the following lines, until you receive the "END" command, you will receive one of two things:
            //	A car – a string containing any ASCII character, or
            //	The command "green" indicates the start of a green light cycle

            //variable for duration of green light in secs
            int duration = int.Parse(Console.ReadLine());

            //variable for free window in secs
            int freeWindow = int.Parse(Console.ReadLine());

            //initialize the queue of cars
            var cars = new Queue<string>();

            string car = string.Empty;
           
            //counter for cars passed the crossroad
            int counter = 0;

            while (true)
            {
                var passedCars = new List<string>();

                //variable for the input either "car" or "green"
                string input = Console.ReadLine();

                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{counter} total cars passed the crossroads.");

                    return;
                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int secsLeft = duration;

                    while (secsLeft > 0 && cars.Any())
                    {
                        car = cars.Dequeue();
                        secsLeft -= car.Length;
                        passedCars.Add(car);
                        counter++;
                    }

                    secsLeft = duration + freeWindow;

                    foreach (var item in passedCars)
                    {
                        for (int i = 0; i < item.Length; i++)
                        {
                            secsLeft--;
                            if (secsLeft < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{item} was hit at {item[i]}.");

                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
