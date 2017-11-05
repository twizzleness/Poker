using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Round
    {
        private List<Player> Players { get; }
        private Player _winner;

        public Round(List<Player> players)
        {
            Players = players;
        }

        public void DeterminePlayerHandRank()
        {
            Players.ForEach(p => p.Hand.HandRank = RankFactory.GetHandRank(p.Hand.Cards));
        }

        public void DetermineWinner()
        {
            _winner = Players.First();

            foreach (var player in Players.Skip(1))
            {
                if (GetPlayerHandRank(player) > GetPlayerHandRank(_winner))
                {
                    _winner = player;
                }
                else if (GetPlayerHandRank(player) == GetPlayerHandRank(_winner))
                {
                    for (var i = 0; i < _winner.Hand.Cards.Count; i++)
                    {
                        if (player.Hand.Cards[i].CardValue >
                            _winner.Hand.Cards[i].CardValue)
                        {
                            _winner = player;
                            break;
                        }
                        if (player.Hand.Cards[i].CardValue !=
                                 _winner.Hand.Cards[i].CardValue)
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void SortPlayerCards()
        {
            Players.ForEach(p => p.Hand.SortCards());
        }

        public Player GetWinningPlayer()
        {
            return _winner;
        }

        private static HandRank GetPlayerHandRank(Player player)
        {
            return player.Hand.HandRank.GetHandRank();
        }

        public void PrintWinner()
        {
            Console.WriteLine($"The winner is {_winner.Name} with a hand of {_winner.Hand.GetHandRank()}\n");
        }
    }
}