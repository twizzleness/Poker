using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Poker
{
    class Round
    {
        public List<Player> Players { get; set; }

        public Round(List<Player> players)
        {
            Players = players;
        }

        public void DeterminePlayerHandRank()
        {
            Players.ForEach(p => p.Hand.HandRank = RankFactory.GetHandRank(p.Hand.Cards));
        }

        public Player DetermineWinner()
        {
            var winner = Players.First();

            foreach (var player in Players.Skip(1))
            {
                if (PlayerHandRank(player) > PlayerHandRank(winner))
                {
                    winner = player;
                }

                var winningCards = player.Hand.Cards.Where(c => Group(c.CardValue));

                /*
                 grab the first oplayer and make them the winner
                 check each other player to see if they have a higher ranking and set them to the winner if they have a
                 higher ranking

                if they have the same ranking
                    compair cards not part of the ranking
                    high card wins

                
                 * */
            }

            return winner;
        }

        HandRank PlayerHandRank(Player player)
        {
            return player.Hand.HandRank.GetHandRank();
        }

    }
}