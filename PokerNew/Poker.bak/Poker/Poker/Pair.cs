using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Pair : IRank
    {
        public List<Card> SortedCards { get; set; }

        public Pair(List<Card> cards)
        {
            SortedCards = cards
                .GroupBy(c => c.CardValue)
                .SelectMany(group => group)
                .OrderByDescending(c => c.CardValue == SetOfCardsWithSameValue.WinningValue(cards, 2))
                .ThenByDescending(c => c.CardValue)
                .ToList();
        }

        public HandRank GetHandRank()
        {
            return HandRank.Pair;
        }

        public List<Card> GetSortedCards()
        {
            return SortedCards;
        }

        public static bool IsPair(List<Card> cards)
        {
            return cards.GroupBy(v => v.CardValue).Any(v => v.Count() == 2);
        }
    }
}