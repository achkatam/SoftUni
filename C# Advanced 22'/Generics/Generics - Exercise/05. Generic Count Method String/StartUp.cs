using System;

namespace _05._Generic_Count_Method_String
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                box.Values.Add(input);
            }

            string itemToCompare = Console.ReadLine();

            Console.WriteLine(box.Count(itemToCompare));
        }
    }
}
