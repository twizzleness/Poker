using System.Collections.Generic;

namespace Poker
{
    static class RankFactory
    {
        public static IRank GetHandRank(List<Card> cards)
        {
            if(Flush.IsFlush(cards))
            {
                return new Flush(cards);
            }

            if (ThreeOfAKind.IsThreeOfAKind(cards))
            {
                return new ThreeOfAKind(cards);
            }

            if (Pair.IsPair(cards))
            {
                return new Pair(cards);
            }

            if (HighCard.IsHighCard(cards))
            {
                return new HighCard();
            }

            return null;
        }
        
    }
}