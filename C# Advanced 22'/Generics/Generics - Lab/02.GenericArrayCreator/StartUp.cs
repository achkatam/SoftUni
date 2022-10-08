using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "Pesho");

            Console.WriteLine(String.Join(", ", strings));

            int[] integers = ArrayCreator.Create(10, 33);
            Console.WriteLine(String.Join(", ", integers));

        }
    }
}
