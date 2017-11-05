namespace Poker
{
    class Card
    {
        public Suit Suit { get; set; }
        public CardValue CardValue { get; set; }

        public Card(Suit suit, CardValue cardValue)
        {
            Suit = suit;
            CardValue = cardValue;
        }
    }
}