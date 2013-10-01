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
<<<<<<< HEAD
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
=======
            // Straight
            Console.WriteLine(player1.Cards.CheckHandForStraight() 
                ? player2.Cards.CheckHandForStraight() ? String.Format("player 2 wins win a straight - {0}", player2.Cards) : ""
                : String.Format("player 1 wins win a straight - {0}", player1.Cards));

            // Flush
            Console.WriteLine(player1.Cards.CheckHandForFlush()
                ? player2.Cards.CheckHandForFlush() ? String.Format("player 2 wins win a flush - {0}", player2.Cards) : ""
                : String.Format("player 1 wins win a flush - {0}", player1.Cards));

            // Four of a kind
            Console.WriteLine(player1.Cards.CheckHandForValueMatches(4)
                ? player2.Cards.CheckHandForValueMatches(4) ? String.Format("player 2 wins win a four of a kind - {0}", player2.Cards) : ""
                : String.Format("player 1 wins win a four of a kind - {0}", player1.Cards));

            // Full house
            Console.WriteLine(player1.Cards.CheckHandForFullHouse()
                ? player2.Cards.CheckHandForFullHouse() ? String.Format("player 2 wins win a full house - {0}", player2.Cards) : ""
                : String.Format("player 1 wins win a full house - {0}", player1.Cards));

            // Three of a kind
            Console.WriteLine(player1.Cards.CheckHandForValueMatches(3)
                ? player2.Cards.CheckHandForValueMatches(3) ? String.Format("player 2 wins win a three of a kind - {0}", player2.Cards) : ""
                : String.Format("player 1 wins win a three of a kind - {0}", player1.Cards));

            // Two of a kind
            Console.WriteLine(player1.Cards.CheckHandForValueMatches(2)
                ? player2.Cards.CheckHandForValueMatches(2) ? String.Format("player 2 wins win a two of a kind - {0}", player2.Cards) : ""
                : String.Format("player 1 wins win a two of a kind - {0}", player1.Cards));

            // High card
            Console.WriteLine(player1.Cards[0].Value > player2.Cards[0].Value
                ? string.Format("player1 won with a high hand of {0} vs. {1}", player1.Cards[0], player2.Cards[0])
                : string.Format("player2 won with a high hand of {0} vs. {1}", player2.Cards[0], player1.Cards[0]));
>>>>>>> Game update
        }
    }
}