using System;

namespace _07.Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] drinkTokens = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] numbersTokens = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Tuple<string, string> nameAdress = new Tuple<string, string>
            {
                Item = $"{tokens[0]} {tokens[1]}",
                Item2 = $"{tokens[2]}"
            };

            var nameBeer = new Tuple<string, int>
            {
                Item = $"{drinkTokens[0]}",
                Item2 = int.Parse(drinkTokens[1])
            };


            var numbers = new Tuple<int, double>
            {
                Item = int.Parse(numbersTokens[0]),
                Item2 = double.Parse(numbersTokens[1])
            };

            Console.WriteLine(nameAdress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(numbers);

        }
    }
}
