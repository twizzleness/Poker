using System;
using System.Collections.Generic;

namespace Poker
{
    class Program
    {
        static void Main()
        {
            var players = new List<Player>
            {
                new Player(
                    new Hand(
                        new List<Card>
                        {
                            new Card(Suit.Club, CardValue.Ace),
                            new Card(Suit.Heart, CardValue.Jack),
                            new Card(Suit.Spade, CardValue.Five),
                            new Card(Suit.Diamond, CardValue.Two),
                            new Card(Suit.Club, CardValue.Three)
                        }), 
                    "Tyler"),
                new Player(
                    new Hand(
                        new List<Card>
                        {
                            new Card(Suit.Heart, CardValue.Ace),
                            new Card(Suit.Heart, CardValue.Jack),
                            new Card(Suit.Heart, CardValue.Five),
                            new Card(Suit.Heart, CardValue.Two),
                            new Card(Suit.Heart, CardValue.Three)
                        }),
                    "Jack")
            };

            var round = new Round(players);
            round.DeterminePlayerHandRank();
            var winningPlayer = round.DetermineWinner();

            Console.WriteLine($"The winner is {winningPlayer.Name} with a hand of {winningPlayer.Hand.HandRank.GetHandRank()}");

            players.ForEach(p => Print(p.Name, p.Hand.HandRank.GetHandRank()));

            
        }

        static void Print(string name, HandRank handRank)
        {
            Console.WriteLine($"{name} {handRank}");
        }

    }
}
