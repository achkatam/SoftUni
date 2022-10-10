
using System;

namespace _08.Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] drinkTokens = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] bankTokens = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var nameAdress = new Threeuple<string, string, string>
            {
                Item = $"{tokens[0]} {tokens[1]}",
                Item2 = $"{tokens[2]}",
                Item3 = $"{tokens[3]}"
            };

            var drink = new Threeuple<string, int, bool>
            {
                Item = $"{drinkTokens[0]}",
                Item2 = int.Parse(drinkTokens[1]),
                Item3 = drinkTokens[2] == "drunk"
            };


            var bankAcc = new Threeuple<string, double, string>
            {
                Item = bankTokens[0],
                Item2 = double.Parse(bankTokens[1]),
                Item3 = bankTokens[2]
            };

            Console.WriteLine(nameAdress);
            Console.WriteLine(drink);
            Console.WriteLine(bankAcc);
        }
    }
}
