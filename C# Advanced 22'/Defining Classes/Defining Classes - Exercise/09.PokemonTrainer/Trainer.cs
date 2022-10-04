using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;

        }
        public string Name { get; set; }
        public int NumberOfCollection { get; set; }
        public List<Pokemon> Pokemons = new List<Pokemon>();

        public void AddBadge()
        {
            NumberOfCollection++;
        }

        public void ReducePokemonHp()
        {
            foreach (var pokemon in Pokemons)
            {
                //all of his pokemon lose 10 health
                pokemon.Health -= 10;
            }
        }

        public void ClearDeadOnes()
        {

            //he dies and must be deleted 
            Pokemons.RemoveAll(x => x.Health <= 0);
        }

        public override string ToString() => $"{Name} {NumberOfCollection} {Pokemons.Count}";

    }
}
