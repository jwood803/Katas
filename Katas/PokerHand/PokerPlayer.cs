namespace PokerHand
{
    using System;
    using System.Collections.Generic;

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
            var card = new Card();

            for (int i = 0; i < 5; i++)
            {
                // How to start at 2?
                var randomCardValue = random.Next(2, 14);
                var randomSuit = random.Next(1, 4);

                card.Value = (CardValue)randomCardValue;
                card.Suit = (Suit)randomSuit;

                cards.Add(card);
            }

            return cards;
        }
    }
}