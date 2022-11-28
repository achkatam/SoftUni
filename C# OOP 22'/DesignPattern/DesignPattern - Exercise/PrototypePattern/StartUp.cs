namespace PrototypePattern
{
    using PrototypePattern.Models;
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            SandwichMenu menu = new SandwichMenu();

            //In case of using deep copy menu is unchangeable
            menu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            menu["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly");
            menu["Turkey"] = new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");

            menu["LoadedBLT"] = new Sandwich("Wheat", "Turkey, Bacon", "American", "Lettuce, Onion, Olives");
            menu["ThreeMeatCombo"] = new Sandwich("Rye", "Turkey, Ham, Salami", "Provolone", "Lettuce, Onion");
            menu["Vegeterian"] = new Sandwich("Wheat", "", "", "Lettuce, Onion, Tomato, Olives, Spinach");

            //User can modify the sandwiches copies as they are clonings 
            Sandwich sandwich1 = menu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2 = menu["ThreeMeatCombo"].Clone() as Sandwich;
            Sandwich sandwich3 = menu["Vegeterian"].Clone() as Sandwich;
        }
    }
}
