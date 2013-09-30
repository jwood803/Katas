namespace PokerHand
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PokerRank
    {
        private PokerPlayer player1;
        private PokerPlayer player2;

        public PokerRank(PokerPlayer player1, PokerPlayer player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        internal bool HasStraightWinner()
        {
            return false;
        }
    }
}