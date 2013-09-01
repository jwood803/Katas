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

        private bool HasFlush(List<Card> cards)
        {
            // TODO: Possible to get a distinct of the suits and if only one remains


            return true;
        }

        internal void SortHand(List<Card> hand)
        {
            hand.Sort((card, nextCard) => nextCard.Value.CompareTo(card.Value));
        }
    }
}