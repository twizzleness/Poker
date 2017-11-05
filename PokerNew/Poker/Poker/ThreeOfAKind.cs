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

        public List<Card> SortCards(List<Card> cards)
        {
            return cards
                .GroupBy(c => c.CardValue)
                .SelectMany(group => group)
                .OrderByDescending(c => c.CardValue == SetOfCardsWithSameValue.WinningValue(cards, 3))
                .ThenByDescending(c => c.CardValue)
                .ToList(); 
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