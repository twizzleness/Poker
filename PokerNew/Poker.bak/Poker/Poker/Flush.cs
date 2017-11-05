using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Flush : IRank
    {
        private List<Card> SortedCards{ get; set; }

        public Flush(List<Card> cards)
        {
            SortedCards = cards.OrderByDescending(c => c.CardValue).ToList();
        }

        public HandRank GetHandRank()
        {
            return HandRank.Flush;
        }

        public List<Card> GetSortedCards()
        {
            return SortedCards;
        }

        public static bool IsFlush(List<Card> cards)
        {
            var suitOfFirstCard = cards.First().Suit;
            return cards.All(v => v.Suit == suitOfFirstCard);
        }
    }
}