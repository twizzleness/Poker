using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Flush : IRank
    {
        public HandRank GetHandRank()
        {
            return HandRank.Flush;
        }

        public static bool IsFlush(List<Card> cards)
        {
            var suitOfFirstCard = cards.First().Suit;
            return cards.All(v => v.Suit == suitOfFirstCard);
        }
    }
}