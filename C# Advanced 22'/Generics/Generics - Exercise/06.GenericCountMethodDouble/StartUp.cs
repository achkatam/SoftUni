using System;

namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());

                box.Values.Add(input);
            }

            double numToCompare = double.Parse(Console.ReadLine());


            Console.WriteLine(box.Count(numToCompare));
        }
    }
}
