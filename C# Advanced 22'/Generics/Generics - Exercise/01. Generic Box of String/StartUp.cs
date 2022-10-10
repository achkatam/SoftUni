using System;
using System.Collections.Generic;

namespace _01._Generic_Box_of_String
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Box<string> box = new Box<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();

                box.Values.Add(value);
            }

            Console.WriteLine(box.ToString());
        }
    }
}
