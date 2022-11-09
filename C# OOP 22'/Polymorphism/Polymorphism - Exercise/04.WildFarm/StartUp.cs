namespace WildFarm
{
    using Factories;
    using Factories;
    using global::Factories;
    using WildFarm.Core;
    using WildFarm.Core.Contracts;
    using WildFarm.Factories;
    using WildFarm.Factories.Contracts;
    using WildFarm.IO;
    using WildFarm.IO.Contracts;

    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new Reader();
            IWriter writer = new Writer();
            IAnimalFactory animalFactory = new AnimalFactory();
            IFoodFactory foodFactory = new FoodFactory();

            IEngine engine = new Engine(reader, writer, animalFactory, foodFactory);
            engine.Run();
        }
    }
}
