using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var trainers = new List<Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                //"{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
                var tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var trainerName = tokens[0];

                //Pokemon's data
                var pokemonName = tokens[1];
                string element = tokens[2];
                int hp = int.Parse(tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, element, hp);

                var currTrainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (currTrainer != null)
                {
                    currTrainer.Pokemons.Add(pokemon);
                }
                else
                {
                    var trainer = new Trainer(trainerName);

                    trainer.Pokemons.Add(pokemon);

                    trainers.Add(trainer);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                CheckMethods(trainers, command);

                command = Console.ReadLine();
            }

            PrintOutput(trainers);

        }

        static void PrintOutput(List<Trainer> trainers)
        {
            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfCollection))
            {
                Console.WriteLine(trainer);
            }

        }

        static void CheckMethods(List<Trainer> trainers, string command)
        {
            string element = command;

            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.FirstOrDefault(p => p.Element == element) != null)
                {
                    trainer.AddBadge();
                }
                else
                {
                    trainer.ReducePokemonHp();
                }

                trainer.ClearDeadOnes();
            }
        }

    }
}
