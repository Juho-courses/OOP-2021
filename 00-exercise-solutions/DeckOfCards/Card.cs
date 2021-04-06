namespace DeckOfCards
{
    public class Card
    {
        public int Rank { get; private set; }
        public string Suit { get; private set; }

        public Card(int rank, string suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public string Print()
        {
            return $"{Rank} of {Suit}s";
        }
    }
}