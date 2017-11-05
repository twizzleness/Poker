using System;

namespace Poker
{
    class Player
    {
        public Hand Hand { get; set; }
        public String Name { get; set; }

        public Player(Hand hand, String name)
        {
            Hand = hand;
            Name = name;
        }
    }
}