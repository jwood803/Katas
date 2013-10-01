namespace PokerHand.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
<<<<<<< HEAD
=======
    using Microsoft.VisualStudio.TestTools.UnitTesting;
>>>>>>> Game update

    [TestClass]
    public class PokerPlayerTests
    {
        [TestMethod]
        public void Tests()
        {
            var player = new PokerPlayer("name");

            var hand = player.GenerateNewHand();

            Assert.IsTrue(hand.Count > 0);
        }

        [TestMethod]
<<<<<<< HEAD
        public void GameTest()
        {
            //var game = new PokerGame("name1", "name2");
        }

        [TestMethod]
=======
>>>>>>> Game update
        public void StraightTest()
        {
            var list = new List<Card>
            {
                new Card { Value = CardValue.Four, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Five, Suit = Suit.Hearts },
                new Card { Value = CardValue.Seven, Suit = Suit.Spades },
                new Card { Value = CardValue.Six, Suit = Suit.Clubs },
                new Card { Value = CardValue.Three, Suit = Suit.Diamonds }
            };

            list.SortValues();

            Assert.IsTrue(list.CheckHandForStraight());
        }

        [TestMethod]
        public void FlushTestReturnsTrue()
        {
            var list = new List<Card>
            {
                new Card { Value = CardValue.Four, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Five, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Seven, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Six, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Three, Suit = Suit.Diamonds }
            };

            list.SortValues();

            Assert.IsTrue(list.CheckHandForFlush());
        }

        [TestMethod]
        public void FlushTestReturnsFalse()
        {
            var list = new List<Card>
            {
                new Card { Value = CardValue.Four, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Five, Suit = Suit.Clubs },
                new Card { Value = CardValue.Seven, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Six, Suit = Suit.Spades },
                new Card { Value = CardValue.Three, Suit = Suit.Diamonds }
            };

            list.SortValues();

            Assert.IsFalse(list.CheckHandForFlush());
        }

        [TestMethod]
        public void TwoOfAKindTest()
        {
            var list = new List<Card>
            {
                new Card {Value = CardValue.Four, Suit = Suit.Diamonds},
                new Card {Value = CardValue.Five, Suit = Suit.Clubs},
                new Card {Value = CardValue.Three, Suit = Suit.Diamonds},
                new Card {Value = CardValue.Six, Suit = Suit.Spades},
                new Card {Value = CardValue.Three, Suit = Suit.Diamonds}
            };

            list.SortValues();

            Assert.IsTrue(list.CheckHandForValueMatches(4));
        }

        [TestMethod]
        public void ThreeOfAKindTest()
        {
            var list = new List<Card>
            {
                new Card {Value = CardValue.Four, Suit = Suit.Diamonds},
                new Card {Value = CardValue.Three, Suit = Suit.Clubs},
                new Card {Value = CardValue.Three, Suit = Suit.Diamonds},
                new Card {Value = CardValue.Six, Suit = Suit.Spades},
                new Card {Value = CardValue.Three, Suit = Suit.Diamonds}
            };

            list.SortValues();

            Assert.IsTrue(list.CheckHandForValueMatches(3));
        }

        [TestMethod]
        public void FourOfAKindTest()
        {
            var list = new List<Card>
            {
                new Card {Value = CardValue.Four, Suit = Suit.Diamonds},
                new Card {Value = CardValue.Three, Suit = Suit.Clubs},
                new Card {Value = CardValue.Three, Suit = Suit.Hearts},
                new Card {Value = CardValue.Three, Suit = Suit.Spades},
                new Card {Value = CardValue.Three, Suit = Suit.Diamonds}
            };

            list.SortValues();

            Assert.IsTrue(list.CheckHandForValueMatches(2));
        }

        [TestMethod]
        public void FullHouseTest()
        {
            var list = new List<Card>
            {
                new Card { Value = CardValue.Five, Suit = Suit.Hearts },
                new Card { Value = CardValue.Five, Suit = Suit.Spades },
                new Card { Value = CardValue.Ten, Suit = Suit.Hearts },
                new Card { Value = CardValue.Ten, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Ten, Suit = Suit.Clubs }
            };

            list.SortValues();

            Assert.IsTrue(list.CheckHandForFullHouse());
        }

        [TestMethod]
        public void FullHouseTest2()
        {
            var list = new List<Card>
            {
                new Card { Value = CardValue.Five, Suit = Suit.Hearts },
                new Card { Value = CardValue.Five, Suit = Suit.Spades },
                new Card { Value = CardValue.Five, Suit = Suit.Clubs },
                new Card { Value = CardValue.Ten, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Ten, Suit = Suit.Clubs }
            };

            list.SortValues();

            Assert.IsTrue(list.CheckHandForFullHouse());
        }

        [TestMethod]
        public void FullHouseTest3()
        {
            var list = new List<Card>
            {
                new Card { Value = CardValue.Five, Suit = Suit.Hearts },
                new Card { Value = CardValue.Nine, Suit = Suit.Spades },
                new Card { Value = CardValue.Five, Suit = Suit.Hearts },
                new Card { Value = CardValue.Ten, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Ten, Suit = Suit.Clubs }
            };

            list.SortValues();

            Assert.IsFalse(list.CheckHandForFullHouse());
        }

        [TestMethod]
        public void FullHouseTest4()
        {
            var list = new List<Card>
            {
                new Card { Value = CardValue.Five, Suit = Suit.Hearts },
                new Card { Value = CardValue.Five, Suit = Suit.Spades },
                new Card { Value = CardValue.Five, Suit = Suit.Clubs },
                new Card { Value = CardValue.Five, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Ten, Suit = Suit.Clubs }
            };

            list.SortValues();

            Assert.IsFalse(list.CheckHandForFullHouse());
        }
    }
}