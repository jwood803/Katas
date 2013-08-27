namespace PokerHand
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var player1Hand = new List<string>();
            var player2Hand = new List<string>();

            var hand = new PokerHand(player1Hand, player2Hand);

            hand.DisplayWinner();
        }
    }
}