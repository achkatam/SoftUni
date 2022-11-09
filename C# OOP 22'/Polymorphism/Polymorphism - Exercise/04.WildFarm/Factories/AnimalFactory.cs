namespace WildFarm.Factories
{

    using Exceptions;
    using Contracts;
    using Models.Contracts;
    using Models.Animals;

    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal(string[] tokens)
        {
            string type = tokens[0];
            string name = tokens[1];
            double weight = double.Parse(tokens[2]);
            string fourthTokens = tokens[3];

            IAnimal animal;

            if (type == "Owl")
            {
                animal = new Owl(name, weight, double.Parse(fourthTokens));
            }
            else if (type == "Hen")
            {
                animal = new Hen(name, weight, double.Parse(fourthTokens));
            }
            else if (type== "Mouse")
            {
                animal = new Mouse(name, weight, fourthTokens);
            }
            else if (type == "Dog")
            {
                animal = new Dog(name, weight, fourthTokens);
            }
            else if (type == "Cat")
            {
                animal = new Cat(name, weight, fourthTokens, tokens[4]);
            }
            else if (type == "Tiger")
            {
                animal = new Tiger(name, weight, fourthTokens, tokens[4]);
            }
            else
            {
                throw new InvalidAnimalTypeException();
            }

            return animal;
        }
    }
}
