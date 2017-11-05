using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Program
    {
        static void Main()
        {
            var rounds = GetPlayers();
            rounds.ForEach(PlayRound);
        }

        private static void PlayRound(List<Player> players)
        {
            var round = new Round(players);
            round.DeterminePlayerHandRank();
            round.SortPlayerCards();
            round.DetermineWinner();
            round.PrintWinner();
            players.ForEach(Print);
        }

        private static void Print(Player player)
        {
            Console.WriteLine($"{player.Name} {player.Hand.GetHandRank()}");
            player.Hand.Cards.ForEach(c => Console.WriteLine($"{c.Suit} {c.CardValue}"));
            Console.WriteLine("");
        }

        static List<List<Player>> GetPlayers()
        {
            return new List<List<Player>>
            {
                new List<Player>{
                new Player(
                    new Hand(
                        new List<Card>
                        {
                            new Card(Suit.Heart, CardValue.Three),
                            new Card(Suit.Heart, CardValue.Six),
                            new Card(Suit.Heart, CardValue.Eight),
                            new Card(Suit.Heart, CardValue.Jack),
                            new Card(Suit.Heart, CardValue.King)
                        }),
                        "Joe"),
                new Player(
                    new Hand(
                        new List<Card>
                        {
                            new Card(Suit.Club, CardValue.Three),
                            new Card(Suit.Diamond, CardValue.Three),
                            new Card(Suit.Spade, CardValue.Three),
                            new Card(Suit.Club, CardValue.Eight),
                            new Card(Suit.Diamond, CardValue.Ten)
                        }),
                        "Jen"),
                new Player(
                    new Hand(
                        new List<Card>
                        {
                            new Card(Suit.Heart, CardValue.Two),
                            new Card(Suit.Club, CardValue.Five),
                            new Card(Suit.Spade, CardValue.Seven),
                            new Card(Suit.Club, CardValue.Ten),
                            new Card(Suit.Club, CardValue.Ace)
                        }),
                    "Bob")
                },
                new List<Player>
                {
                    new Player(
                        new Hand(
                            new List<Card>
                            {
                                new Card(Suit.Heart, CardValue.Three),
                                new Card(Suit.Diamond, CardValue.Four),
                                new Card(Suit.Club, CardValue.Nine),
                                new Card(Suit.Diamond, CardValue.Nine),
                                new Card(Suit.Heart, CardValue.Queen)
                            }),
                        "Joe"),
                    new Player(
                        new Hand(
                            new List<Card>
                            {
                                new Card(Suit.Club, CardValue.Five),
                                new Card(Suit.Diamond, CardValue.Seven),
                                new Card(Suit.Heart, CardValue.Nine),
                                new Card(Suit.Spade, CardValue.Nine),
                                new Card(Suit.Spade, CardValue.Queen)
                            }),
                        "Jen"),
                    new Player(
                        new Hand(
                            new List<Card>
                            {
                                new Card(Suit.Heart, CardValue.Two),
                                new Card(Suit.Club, CardValue.Two),
                                new Card(Suit.Spade, CardValue.Five),
                                new Card(Suit.Club, CardValue.Ten),
                                new Card(Suit.Heart, CardValue.Ace)
                            }),
                        "Bob")
                }

            };
        }
    }
}
