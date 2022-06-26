using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize variable
            int waitingPpl = int.Parse(Console.ReadLine());
            //Initialize array
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //lift capacity
            const int wagonCapacity = 4;

            //For loop to iterate thru the array
            for (int i = 0; i < lift.Length; i++)
            {
                for (int j = lift[i]; j < wagonCapacity; j++)
                {
                    lift[i]++;
                    waitingPpl--;

                    if (waitingPpl == 0)
                    {
                        if (lift.Sum() < lift.Length * wagonCapacity)
                        {
                            Console.WriteLine("The lift has empty spots!");
                        }
                        Console.WriteLine(string.Join(' ', lift));

                        return;
                    }

                }
            }

            Console.WriteLine($"There isn't enough space! {waitingPpl} people in a queue!");
            Console.WriteLine(string.Join(' ', lift));

        }
    }
}
