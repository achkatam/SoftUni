using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList myList = new RandomList();

            myList.Add("Hello");
            myList.Add("World");

            Console.WriteLine(myList.RandomString());
        }
    }
}
