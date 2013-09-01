using System.Linq;

namespace PokerHand
{
    using System;
    using System.Collections.Generic;

    public class PokerGame
    {
        public PokerGame(string p1Name, string p2Name)
        {
            var player1 = new PokerPlayer(p1Name);
            var player2 = new PokerPlayer(p2Name);

            this.SortHand(player1.Cards);
            this.SortHand(player2.Cards);

            //RankHands(player1, player2);
        }

        internal void RankHands(PokerPlayer player1, PokerPlayer player2)
        {
            // TODO: Check suit and card combinations
            //if (HasFlush(player1.Cards))
            //{
                
            //}
            //else if(HasFlush(player2.Cards))
            //{
                
            //}

            HasStraight(player1.Cards);

            // Check high card
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

        internal bool HasAtLeastTwoOfAKind(List<Card> cards)
        {
            var cardValues = new List<CardValue>();

            cards.ForEach(card => cardValues.Add(card.Value));

            var distinctValues = cardValues.Distinct();
            
            // TODO: Can we use a method that passes in a predicate to test each of the other hands?
            return distinctValues.Count() < 5;
        }

        internal void SortHand(List<Card> hand)
        {
            hand.Sort((card, nextCard) => nextCard.Value.CompareTo(card.Value));
        }
    }
}