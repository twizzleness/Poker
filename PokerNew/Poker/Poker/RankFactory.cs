using System.Collections.Generic;

namespace Poker
{
    static class RankFactory
    {
        public static IRank GetHandRank(List<Card> cards)
        {
            if(Flush.IsFlush(cards))
            {
                return new Flush();
            }

            if (ThreeOfAKind.IsThreeOfAKind(cards))
            {
                return new ThreeOfAKind();
            }

            if (Pair.IsPair(cards))
            {
                return new Pair();
            }

            if (HighCard.IsHighCard(cards))
            {
                return new HighCard();
            }

            return null;
        }
        
    }
}