using System;

namespace Interface_And_Interface_Inheritance
{
    public interface Animal
    {
        void Speak();
    }public class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine($"Woof Woof");
        }
    }
    public class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine($"Meow Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Interface_And_Interface_Inheritance
            Animal[] animals =
            {
                new Dog(),
                new Cat()
            };
            foreach(Animal animal in animals)
            {
                animal.Speak();
            }
        }
    }
}
