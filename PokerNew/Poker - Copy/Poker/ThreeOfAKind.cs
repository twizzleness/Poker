using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class ThreeOfAKind : IRank
    {
        private List<Card> SortedCards { get; set; }

        /****************
         Group Cards by winning value then by the rest of the cards in descending order
        ******************/

        public ThreeOfAKind(List<Card> cards)
        {
            SortedCards = cards
                .GroupBy(c => c.CardValue)
                .SelectMany(group => group)
                .OrderByDescending(c => c.CardValue == SetOfCardsWithSameValue.WinningValue(cards, 3))
                .ThenByDescending(c => c.CardValue)
                .ToList();
        }

        public HandRank GetHandRank()
        {
            return HandRank.ThreeOfAKind;
        }

        public List<Card> GetSortedCards()
        {
            return SortedCards;
        }

        public static bool IsThreeOfAKind(List<Card> cards)
        {
            return cards.GroupBy(v => v.CardValue).Any(v => v.Count() == 3);
        }
    }

    class SetOfCardsWithSameValue
    {
        public static CardValue WinningValue(List<Card> cards, int amount)
        {
            return cards
                .GroupBy(v => v.CardValue)
                .FirstOrDefault(v => v.Count() == amount)
                .Key;
        }
    }
}