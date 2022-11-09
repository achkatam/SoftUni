namespace Cards
{
    using System;
    using System.Collections.Generic;
    class Card
    {
        //•	\u2660 – Spades (♠)
        //•	\u2665 – Hearts(♥)
        //•	\u2666 – Diamonds(♦)
        //•	\u2663 – Clubs(♣)

        Dictionary<string, char> suits = new Dictionary<string, char>
        {
            {"H", '\u2665'},
            {"C", '\u2663'},
            {"D", '\u2666'},
            {"S", '\u2660'},
        };



        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face { get; set; }

        public string Suit { get; set; }

        public override string ToString()
        {
            return $"[{Face}{suits[Suit]}]";
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

            List<Card> cards = new List<Card>();

            var cardsInfo = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var cardInfo in cardsInfo)
            {
                Card card;

                try
                {
                    var cardData = cardInfo
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string face = cardData[0];
                    string suit = cardData[1];

                    card = CardFactory(face, suit);

                    cards.Add(card);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }

            foreach (var item in cards)
            {
                Console.Write($"{item.ToString()} ");
            }

        }

        private static Card CardFactory(string face, string suit)
        {
            List<string> faces = new List<string>()
        {
            "2", "3", "4", "5", "6", "7", "8", "9", "10",
            "J", "Q", "K", "A"
        };

            Card card;

            if (!faces.Contains(face))
                throw new ArgumentException("Invalid card!");

            if (suit != "H" && suit != "C"
                && suit != "D" && suit != "S")
                throw new ArgumentException("Invalid card!");

            card = new Card(face, suit);

            return card;
        }
    }
}
