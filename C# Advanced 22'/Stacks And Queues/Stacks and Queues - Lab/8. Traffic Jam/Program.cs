using System;
using System.Linq;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //input for cars to pass the light
            int carsToPass = int.Parse(Console.ReadLine());

            //Create queue
            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();

            //counter for passed cars
            int counter = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsToPass; i++)
                    {
                        if (cars.Count > 0)
                        {
                            string car = cars.Dequeue();

                            Console.WriteLine($"{car} passed!");
                            counter++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);  
                }

                command = Console.ReadLine();   

            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
