using System.Collections.Generic;

namespace Poker
{
    class Hand
    {
        public List<Card> Cards { get; set; }
        public IRank HandRank { get; set; }

        public Hand(List<Card> cards)
        {
            Cards = cards;
            HandRank = null;
        }

        public void SortCards()
        {
            Cards = HandRank.SortCards(Cards);
        }

        public HandRank GetHandRank()
        {
            return HandRank.GetHandRank();
        }
        
    }
}