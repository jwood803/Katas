using System.Collections.Generic;

namespace PokerHand
{
    public class PokerHand
    {
        private List<string> _player1Hand;
        private List<string> _player2Hand;

        public PokerHand(List<string> player1Hand, List<string> player2Hand)
        {
            this._player1Hand = player1Hand;
            this._player2Hand = player2Hand;
        }

        public string DisplayWinner()
        {
            var pokerLogic = new PokerLogic();

            for (int i = 0; i <= _player1Hand.Count; i++)
            {
                // Check each players hands. See which one has the highest hand.
                pokerLogic.CheckHand(_player1Hand[i], _player2Hand[i]);
            }

            return string.Empty;
        }
    }
}