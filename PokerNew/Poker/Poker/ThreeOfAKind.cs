using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class ThreeOfAKind : IRank
    {
        public HandRank GetHandRank()
        {
            return HandRank.ThreeOfAKind;
        }

        public static bool IsThreeOfAKind(List<Card> cards)
        {
            return cards.GroupBy(v => v.CardValue).Any(v => v.Count() == 3);
        }
    }
}