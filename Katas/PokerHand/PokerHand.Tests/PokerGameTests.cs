using System.Collections.Generic;

namespace PokerHand.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public class PokerGameTests
    {
        private PokerGame game;

        [TestClass]
        public class RankHandsMethod : PokerGameTests
        {
            [TestMethod]
            public void Player1WinsWithStraight()
            {
                game = new PokerGame("name1", "name2");

                // Ignore the cards built by constructor for the test
                var p1 = new PokerPlayer("p1");
                var p2 = new PokerPlayer("p2");

                p1.Cards.Clear();
                p2.Cards.Clear();

                game.Player2.Cards.Clear();

                p1.Cards = new List<Card>
                {
                    new Card {Value = CardValue.Four, Suit = Suit.Diamonds},
                    new Card {Value = CardValue.Five, Suit = Suit.Hearts},
                    new Card {Value = CardValue.Seven, Suit = Suit.Spades},
                    new Card {Value = CardValue.Six, Suit = Suit.Clubs},
                    new Card {Value = CardValue.Three, Suit = Suit.Diamonds}
                };

                p2.Cards = new List<Card>
                {
                    new Card {Value = CardValue.Four, Suit = Suit.Diamonds},
                    new Card {Value = CardValue.Ace, Suit = Suit.Hearts},
                    new Card {Value = CardValue.Ten, Suit = Suit.Spades},
                    new Card {Value = CardValue.Two, Suit = Suit.Clubs},
                    new Card {Value = CardValue.King, Suit = Suit.Diamonds}
                };

                game.RankHands(p1, p2);
            }
        }
    }
}