using System.Collections.Generic;

namespace Poker
{
    interface IRank
    {
        HandRank GetHandRank();
        List<Card> GetSortedCards();
    }
}