namespace PokerHand
{
    public class PokerGame
    {
        private PokerPlayer player1;
        private PokerPlayer player2;

        public PokerGame(string p1Name, string p2Name)
        {
            player1 = new PokerPlayer(p1Name);
            player2 = new PokerPlayer(p2Name);
        }


    }
}