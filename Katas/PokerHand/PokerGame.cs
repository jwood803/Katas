namespace PokerHand
{
    using System;

    public class PokerGame
    {
        public PokerPlayer Player1 { get; set; }
        public PokerPlayer Player2 { get; set; }
        
        public PokerGame(string p1Name, string p2Name)
        {
            this.Player1 = new PokerPlayer(p1Name);
            this.Player2 = new PokerPlayer(p2Name);

            this.Player1.Cards.SortValues();
            this.Player2.Cards.SortValues();

            DisplayWinner();
        }

        private void DisplayWinner()
        {
            // Straight
            Console.WriteLine(Player1.Cards.CheckHandForStraight()
                ? Player2.Cards.CheckHandForStraight() ? String.Format("player 2 wins win a straight - {0}", Player2.Cards) : ""
                : String.Format("player 1 wins win a straight - {0}", Player1.Cards));

            // Flush
            Console.WriteLine(Player1.Cards.CheckHandForFlush()
                ? Player2.Cards.CheckHandForFlush() ? String.Format("player 2 wins win a flush - {0}", Player2.Cards) : ""
                : String.Format("player 1 wins win a flush - {0}", Player1.Cards));

            // Four of a kind
            Console.WriteLine(Player1.Cards.CheckHandForValueMatches(4)
                ? Player2.Cards.CheckHandForValueMatches(4) ? String.Format("player 2 wins win a four of a kind - {0}", Player2.Cards) : ""
                : String.Format("player 1 wins win a four of a kind - {0}", Player1.Cards));

            // Full house
            Console.WriteLine(Player1.Cards.CheckHandForFullHouse()
                ? Player2.Cards.CheckHandForFullHouse() ? String.Format("player 2 wins win a full house - {0}", Player2.Cards) : ""
                : String.Format("player 1 wins win a full house - {0}", Player1.Cards));

            // Three of a kind
            Console.WriteLine(Player1.Cards.CheckHandForValueMatches(3)
                ? Player2.Cards.CheckHandForValueMatches(3) ? String.Format("player 2 wins win a three of a kind - {0}", Player2.Cards) : ""
                : String.Format("player 1 wins win a three of a kind - {0}", Player1.Cards));

            // Two of a kind
            Console.WriteLine(Player1.Cards.CheckHandForValueMatches(2)
                ? Player2.Cards.CheckHandForValueMatches(2) ? String.Format("player 2 wins win a two of a kind - {0}", Player2.Cards) : ""
                : String.Format("player 1 wins win a two of a kind - {0}", Player1.Cards));

            // High card
            Console.WriteLine(Player1.Cards[0].Value > Player2.Cards[0].Value
                ? string.Format("Player1 won with a high hand of {0} vs. {1}", Player1.Cards[0], Player2.Cards[0])
                : string.Format("Player2 won with a high hand of {0} vs. {1}", Player2.Cards[0], Player1.Cards[0]));
        }
    }
}