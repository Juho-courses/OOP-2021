using System;
using System.Collections.Generic;


namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        public int CardCount { get; private set; }

        public Deck()
        {
            CreateDeck();
            CardCount = Cards.Count;
        }

        private void CreateDeck()
        {
            string[] suits = { "spade", "diamond", "heart", "club" };

            List<Card> cards = new List<Card>();

            foreach (string suit in suits)
            {
                for (int rank = 1; rank < 14; rank++)
                {
                    Card c = new Card(rank, suit);
                    cards.Add(c);
                }
            }

            Cards = cards;
        }

        public List<Card> DrawRandomN(int n)
        {
            List<Card> ret = new List<Card>();

            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                // pick random number between
                int r = rnd.Next(0, CardCount);
                Card card = Cards[r];
                Cards.RemoveAt(r);
                ret.Add(card);
                CardCount = Cards.Count;
            }

            return ret;
        }

        public List<Card> DrawTopN(int n)
        {
            List<Card> ret = new List<Card>();

            int d_count = 0;
            while (d_count < n)
            {
                Card card = Cards[0];
                Cards.RemoveAt(0);
                ret.Add(card);
                d_count++;
            }
            CardCount = Cards.Count;

            return ret;
        }

        // https://stackoverflow.com/a/1262619
        public void Shuffle()
        {
            System.Console.WriteLine("shuffle shuffle shuffle");
            Random rnd = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                Card value = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = value;
            }
        }
    }
}