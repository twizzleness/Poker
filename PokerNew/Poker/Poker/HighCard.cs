using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class HighCard : IRank
    {
        public HandRank GetHandRank()
        {
            return HandRank.HighCard;
        }

        public List<Card> SortCards(List<Card> cards)
        {
            return cards.OrderByDescending(c => c.CardValue).ToList();
        }

        public static bool IsHighCard(List<Card> cards)
        {
            return true;
        }
    }
}