using System;
using System.Collections.Generic;
using System.Linq;

namespace Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will be given two hands of cards, which will be represented by integers.Assume each one is held by a different player.You have to find which one has the winning deck. You start from the beginning of both hands of cards. Compare the cards from the first deck to the cards from the second deck.The player, who holds the more powerful card on the current iteration, takes both cards and puts them at the back of his hand - the second player's card is placed last, and the first person's card(the winning one) comes after it(second to last)..  The game is over when only one of the decks is left without any cards. 

            //Initialize the lists for 2 player
            var firstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            //While loop until one of them runs out of cards
            while (firstPlayer.Count > 0 && secondPlayer.Count > 0)
            {
                // If statement who has more powerfull card, whose card is more powerful takes his opponents one too 
                if (firstPlayer[0] > secondPlayer[0])
                {
                    firstPlayer.Add(firstPlayer[0]);
                    firstPlayer.Add(secondPlayer[0]);
                }
                else if (firstPlayer[0] < secondPlayer[0])
                {
                    secondPlayer.Add(secondPlayer[0]);
                    secondPlayer.Add(firstPlayer[0]);
                }
                //Remove the first card as it goes to the back of the deck
                firstPlayer.Remove(firstPlayer[0]);
                secondPlayer.Remove(secondPlayer[0]);

            }
            //You have to display the result on the console and the sum of the remaining cards: "{First/Second} player wins! Sum: {sum}".
            if (firstPlayer.Count > secondPlayer.Count)
            {
                Console.WriteLine($"First player wins! Sums: {firstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sums: {secondPlayer.Sum()}");

            }

        }
    }
}
