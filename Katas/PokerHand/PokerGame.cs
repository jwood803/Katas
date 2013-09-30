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

            this.Player1.Cards.Sort();
            this.Player2.Cards.Sort();

            DisplayWinner();
        }

        private void DisplayWinner()
        {
            // Should be called in the PokerRank class
            RankHands();
        }

        internal void RankHands()
        {
            this.Player1.Cards.SortValues();
            this.Player2.Cards.SortValues();

            var pokerRank = new PokerRank(this.Player1, this.Player2);

            // TODO: Add checks in order of highest to lowest. 

            if (pokerRank.HasStraightWinner())
            {

            }

            // CheckForValueMatches(player1.Cards, distinctValues => enumerable.Count() == 4);

            // TODO: Extract this out to a method.
            Console.WriteLine(this.Player1.Cards[0].Value > this.Player2.Cards[0].Value
                ? string.Format("player1 won with a high hand of {0} vs. {1}", this.Player1.Cards[0], this.Player2.Cards[0])
                : string.Format("player2 won with a high hand of {0} vs. {1}", this.Player2.Cards[0], this.Player1.Cards[0]));
        }
    }
}