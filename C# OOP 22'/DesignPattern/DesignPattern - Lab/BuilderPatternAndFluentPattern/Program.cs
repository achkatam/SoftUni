namespace BuilderPatternAndFluentPattern
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.BuildEngine();
            car.BuildNavigation()
                .BuildEngine()
                .BuildNavigation()
                .BuildEngine();

            Console.WriteLine(car);
        }
    }
}
