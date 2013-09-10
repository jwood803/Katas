using System.Linq;

namespace PokerHand
{
    using System;
    using System.Collections.Generic;

    public class PokerGame
    {
        public PokerPlayer Player1 { get; set; }
        public PokerPlayer Player2 { get; set; }
        
        public PokerGame(string p1Name, string p2Name)
        {
            this.Player1 = new PokerPlayer(p1Name);
            this.Player2 = new PokerPlayer(p2Name);

            this.SortHand(this.Player1.Cards);
            this.SortHand(this.Player2.Cards);

            //RankHands(player1, player2);
        }

        internal void RankHands(PokerPlayer player1, PokerPlayer player2)
        {
            // TODO: Add checks in order of highest to lowest.

            HasStraight(player1.Cards);

            // CheckForValueMatches(player1.Cards, distinctValues => enumerable.Count() == 4);

            // TODO: Extract this out to a method.
            Console.WriteLine(player1.Cards[0].Value > player2.Cards[0].Value
                ? string.Format("player1 won with a high hand of {0} vs. {1}", player1.Cards[0], player2.Cards[0])
                : string.Format("player2 won with a high hand of {0} vs. {1}", player2.Cards[0], player1.Cards[0]));
        }

        internal bool HasStraight(List<Card> cards)
        {
            this.SortHand(cards);

            var initialCardValue = cards[0].Value;
            var matchCount = 0;

            cards.ForEach(card =>
            {
                if (initialCardValue == card.Value)
                {
                    matchCount++;
                }

                initialCardValue--;
            });

            return matchCount == cards.Count;
        }

        internal bool HasFlush(List<Card> cards)
        {
            var suits = new List<Suit>();

            cards.ForEach(card => suits.Add(card.Suit));

            var distinctSuits = suits.Distinct();

            return distinctSuits.Count() == 1;
        }

        internal bool CheckForValueMatches(List<Card> cards, Predicate<IEnumerable<CardValue>> predicate)
        {
            var cardValues = new List<CardValue>();

            cards.ForEach(card => cardValues.Add(card.Value));

            var distinctValues = cardValues.Distinct();

            return predicate(distinctValues);
        }

        internal void SortHand(List<Card> hand)
        {
            hand.Sort((card, nextCard) => nextCard.Value.CompareTo(card.Value));
        }
    }
}