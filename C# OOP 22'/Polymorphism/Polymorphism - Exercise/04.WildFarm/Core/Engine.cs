namespace WildFarm.Core
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using Core.Contracts;
    using IO.Contracts;
    using WildFarm.Exceptions;
    using WildFarm.Factories.Contracts;
    using WildFarm.Models.Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly IAnimalFactory animalFactory;
        private readonly IFoodFactory foodFactory;
        private readonly ICollection<IAnimal> animals;

        private Engine()
        {
            this.animals = new HashSet<IAnimal>();
        }

        public Engine(IReader reader, IWriter writer, IAnimalFactory animalFactory, IFoodFactory foodFactory) : this()
        {
            this.reader = reader;
            this.writer = writer;

            this.animalFactory = animalFactory;
            this.foodFactory = foodFactory;
        }


        public void Run()
        {
            string command = this.reader.ReadLine();


             while (command != "End")
            {
                this.HandleInput(command);


                command = this.reader.ReadLine();
            }

            this.PrintAllAnimals();
        }

        private IAnimal BuildAnimalUsingFactory(string command)
        {
            var tokens = command
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            IAnimal currAnimal = this.animalFactory.CreateAnimal(tokens);

            return currAnimal;
        }

        private IFood BuildFoodUsingFactory(string command)
        {
            string[] foodInfo = this.reader.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string foodType = foodInfo[0];
            int foodQnty = int.Parse(foodInfo[1]);

            IFood currFood = this.foodFactory.CreateFood(foodType, foodQnty);

            return currFood;
        }

        private void HandleInput(string command)
        {
            IAnimal currAnimal = null;

            try
            {
                currAnimal = this.BuildAnimalUsingFactory(command);

                IFood currFood = this.BuildFoodUsingFactory(command);

                this.writer.WriteLine(currAnimal.ProduceSound());

                currAnimal.Eat(currFood);

            }
            catch (InvalidAnimalTypeException iate)
            {

                this.writer.WriteLine(iate.Message);
            }
            catch (InvalidFoodTypeException ifte)
            {
                this.writer.WriteLine(ifte.Message);
            }
            catch (FoodNotEatenException fnet)
            {
                this.writer.WriteLine(fnet.Message);
            }
            catch (Exception)
            {
                throw;
            }

            this.animals.Add(currAnimal);

        }

        private void PrintAllAnimals()
        {
            foreach (IAnimal animal in this.animals)
            {
                this.writer.WriteLine(animal.ToString());
            }
        }
    }
}
