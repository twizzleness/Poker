using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Pair : IRank
    {
        public HandRank GetHandRank()
        {
            return HandRank.Pair;
        }

        public static bool IsPair(List<Card> cards)
        {
            return cards.GroupBy(v => v.CardValue).Any(v => v.Count() == 2);
        }
    }
}