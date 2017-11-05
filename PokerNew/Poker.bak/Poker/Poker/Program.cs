using System;
using System.Collections.Generic;
using System.Linq;

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
                            new Card(Suit.Club, CardValue.Four),
                            new Card(Suit.Heart, CardValue.Four),
                            new Card(Suit.Diamond, CardValue.Four),
                            new Card(Suit.Club, CardValue.Two),
                            new Card(Suit.Club, CardValue.Three)
                        }), 
                        "Tyler"),
                new Player(
                    new Hand(
                        new List<Card>
                        {
                            new Card(Suit.Heart, CardValue.Five),
                            new Card(Suit.Spade, CardValue.Five),
                            new Card(Suit.Diamond, CardValue.Five),
                            new Card(Suit.Heart, CardValue.Two),
                            new Card(Suit.Heart, CardValue.Three)
                        }),
                        "Jack")
            };

            var round = new Round(players);
            round.DeterminePlayerHandRank();
            var winningPlayer = round.DetermineWinner();

            Console.WriteLine($"The winner is {winningPlayer.Name} with a hand of {winningPlayer.Hand.HandRank.GetHandRank()}");

            //players.ForEach(p => Print(p.Name, p.Hand.HandRank.GetHandRank()));
            players.ForEach(Print);

           // players.ForEach(p =>
             //   Console.WriteLine($"{p.Name} has a winning value of {p.Hand.HandRank.GetSortedCards().First().CardValue}"));


        }

        static void Print(Player player)
        {
            Console.WriteLine($"{player.Name} {player.Hand.HandRank.GetHandRank()}");
            foreach (var card in player.Hand.HandRank.GetSortedCards())
            {
                Console.WriteLine($"{card.Suit} {card.CardValue}");
            }
            Console.WriteLine("");
        }

        //        static void Print(string name, HandRank handRank)
        //        {
        //            Console.WriteLine($"{name} {handRank}");
        //        }

    }
}
