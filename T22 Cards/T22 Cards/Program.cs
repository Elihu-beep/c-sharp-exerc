using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace T22_Cards
{
    public class Card
    {
        public string Suit { get; private set; }
        public string Value { get; private set; }

        public Card(string suit, string value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }

    public class CardDeck
    {
        private List<Card> cards;

        public CardDeck()
        {
            cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] values = { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public override string ToString()
        {
            string deckString = "";
            foreach (var card in cards)
            {
                deckString += card.ToString() + "\n";
            }
            return deckString.TrimEnd();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CardDeck deck = new CardDeck();
            Console.WriteLine("Original Deck:");
            Console.WriteLine(deck);

            deck.Shuffle();
            Console.WriteLine("\nShuffled Deck:");
            Console.WriteLine(deck);
        }
    }
}