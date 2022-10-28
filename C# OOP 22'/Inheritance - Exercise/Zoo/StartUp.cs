using System;

namespace Zoo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Bear bear = new Bear(name);

            Console.WriteLine(bear.Name);
            
        }
    }
}