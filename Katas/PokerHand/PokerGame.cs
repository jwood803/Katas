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

            //RankHands(player1, player2);
        }

        internal void RankHands(PokerPlayer player1, PokerPlayer player2)
        {
            // TODO: Add checks in order of highest to lowest.

            player1.Cards.CheckHandForStraight();

            // CheckForValueMatches(player1.Cards, distinctValues => enumerable.Count() == 4);

            // TODO: Extract this out to a method.
            Console.WriteLine(player1.Cards[0].Value > player2.Cards[0].Value
                ? string.Format("player1 won with a high hand of {0} vs. {1}", player1.Cards[0], player2.Cards[0])
                : string.Format("player2 won with a high hand of {0} vs. {1}", player2.Cards[0], player1.Cards[0]));
        }
    }
}