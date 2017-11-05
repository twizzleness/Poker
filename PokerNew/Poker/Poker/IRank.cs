using System.Collections.Generic;

namespace Poker
{
    interface IRank
    {
        HandRank GetHandRank();
        List<Card> SortCards(List<Card> cards);
    }
}