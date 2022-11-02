namespace Demo
{
    using Demo.Contracts;
    using System;
    using System.Collections.Generic;

    public class Program
    {
        static void Main(string[] args)
        {

            CareTaker careTaker = new CareTaker();

            careTaker.Feed(new Eagle());
            
            careTaker.Feed(new Fish());

            careTaker.Feed(new Croc());

            IFeedable lion = new Lion();

            //we have only Eat()
            lion.Eat();

            IFeedable baby = new Baby();

            Console.WriteLine();

            baby.Eat();

        }
    }
}
