using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace CocktailParty
{
    public class Cocktail
    {
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            Ingredients = new HashSet<Ingredient>(); 
        }

        public string Name { get; set; }
        public int Capacity { get; set; } // max number of ingredients allowed in a coctail
        public int MaxAlcoholLevel { get; set; } // max allowed alchohol amount in a coctail
        public HashSet<Ingredient> Ingredients { get; set; }

        public void Add(Ingredient ingredient)
        {
            if (!Ingredients.Any(x => x.Name == ingredient.Name) && Ingredients.Count <= Capacity && ingredient.Alcohol <= MaxAlcoholLevel)
            {
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name) => Ingredients.Remove(Ingredients.FirstOrDefault(x => x.Name == name));

        public Ingredient FindIngredient(string name) => Ingredients.FirstOrDefault(x => x.Name == name);

        public Ingredient GetMostAlcoholicIngredient()
        {
            return Ingredients.OrderByDescending(x => x.Alcohol).First();
        }

        public int CurrentAlcoholLevel { get { return Ingredients.Sum(x => x.Alcohol); } }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");

            foreach (var coctail in Ingredients)
            {
                sb.AppendLine(coctail.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
