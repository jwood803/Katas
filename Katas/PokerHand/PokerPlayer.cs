namespace PokerHand
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    [DebuggerDisplay("{this.DisplayHand(), nq}")]
    public class PokerPlayer
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

        public PokerPlayer(string playerName)
        {
            this.Name = playerName;
            this.Cards = GenerateNewHand();
        }

        internal List<Card> GenerateNewHand()
        {
            var random = new Random();
            var cards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                var card = new Card();

                var randomCardValue = random.Next(2, 14);
                var randomSuit = random.Next(1, 4);

                card.Value = (CardValue)randomCardValue;
                card.Suit = (Suit)randomSuit;

                // Can't have the same card (same value and suit) twice
                if (!cards.Contains(card))
                {
                    cards.Add(card);
                }
            }
            
            return cards;
        }

        public override string ToString()
        {
            return string.Format("Player {0} has hand {1}", this.Name, this.DisplayHand());
        }
    }
}