using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();
            //counter for passed cars
            int counter = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0) break;

                        var car = cars.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        counter++;
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
