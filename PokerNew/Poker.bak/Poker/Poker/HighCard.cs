using System.Collections.Generic;

namespace Poker
{
    class HighCard : IRank
    {
        public HandRank GetHandRank()
        {
            return HandRank.HighCard;
        }

        public List<Card> GetSortedCards()
        {
            throw new System.NotImplementedException();
        }

        public static bool IsHighCard(List<Card> cards)
        {
            return true;
        }
    }
}