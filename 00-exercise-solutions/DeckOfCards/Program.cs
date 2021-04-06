using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] suits = { "spade", "diamond", "heart", "club" };

            // List<Card> cards = new List<Card>();

            // foreach (string suit in suits)
            // {
            //     for (int rank = 1; rank < 14; rank++)
            //     {

            //         Card c = new Card(rank, suit);
            //         Console.WriteLine(c.Print());
            //         cards.Add(c);
            //     }
            // }

            Deck deck = new Deck();
            Console.WriteLine("card count " + deck.CardCount);

            // Console.WriteLine(deck.Cards[0].Print());

            List<Card> drawn = new List<Card>();
            // drawn = deck.DrawRandomN(10);

            // foreach (Card c in drawn)
            // {
            //     Console.WriteLine(c.Print());
            // }
            // Console.WriteLine("card count " + deck.CardCount);

            Console.WriteLine("-------------");
            // drawn = deck.DrawTopN(3);
            // foreach (Card c in drawn)
            // {
            //     Console.WriteLine(c.Print());
            // }
            // Console.WriteLine("card count " + deck.CardCount);


            Console.WriteLine(deck.Cards[0].Print());
            deck.Shuffle();
            Console.WriteLine(deck.Cards[0].Print());


        }
    }
}
