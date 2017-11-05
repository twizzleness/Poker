using System.Collections.Generic;

namespace Poker
{
    class HighCard : IRank
    {
        public HandRank GetHandRank()
        {
            return HandRank.HighCard;
        }

        public static bool IsHighCard(List<Card> cards)
        {
            return true;
        }
    }
}