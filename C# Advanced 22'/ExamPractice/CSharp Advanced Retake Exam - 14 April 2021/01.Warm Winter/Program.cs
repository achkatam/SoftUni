using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Stack for hats
            var hats = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            //Queue for scarves
            var scarves = new Queue<int>(Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray());


            List<int> sets = new List<int>();

            while (hats.Any() && scarves.Any())
            {
                int hat = hats.Peek();
                int scarf = scarves.Peek();

                if (hat > scarf)
                {
                    sets.Add(hat + scarf);
                    hats.Pop();
                    scarves.Dequeue();
                }
                else if (scarf > hat)
                {
                    hats.Pop();
                }
                else
                {
                    scarves.Dequeue();
                   
                    hat += 1;
                  
                    hats.Pop();
                    hats.Push(hat);
                }

                //Console.WriteLine(String.Join(" ", hats.Reverse()));
                //Console.WriteLine(String.Join(" ", scarves));
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");

            Console.WriteLine(String.Join(" ", sets));


        }
    }
}
