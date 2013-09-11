namespace PokerHand.Tests
{
    using System.Collections.Generic;
    using NUnit.Framework;

    [TestFixture]
    public class PokerPlayerTests
    {
        [Test]
        public void Tests()
        {
            var player = new PokerPlayer("name");

            var hand = player.GenerateNewHand();

            Assert.IsTrue(hand.Count > 0);
        }

        [Test]
        public void GameTest()
        {
            //var game = new PokerGame("name1", "name2");
        }

        [Test]
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

            Assert.IsTrue(list.CheckHandForStraight());
        }

        [Test]
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

            Assert.IsTrue(list.CheckHandForFlush());
        }

        [Test]
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

            Assert.IsFalse(list.CheckHandForFlush());
        }

        [Test]
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

            Assert.IsTrue(list.CheckHandForValueMatches(4));
        }

        [Test]
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

            Assert.IsTrue(list.CheckHandForValueMatches(3));
        }

        [Test]
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

            Assert.IsTrue(list.CheckHandForValueMatches(2));
        }

        [Test]
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

            Assert.IsTrue(list.CheckHandForFullHouse());
        }

        [Test]
        public void FullHouseTest2()
        {
            var list = new List<Card>
            {
                new Card { Value = CardValue.Five, Suit = Suit.Hearts },
                new Card { Value = CardValue.Five, Suit = Suit.Spades },
                new Card { Value = CardValue.Five, Suit = Suit.Hearts },
                new Card { Value = CardValue.Ten, Suit = Suit.Diamonds },
                new Card { Value = CardValue.Ten, Suit = Suit.Clubs }
            };

            Assert.IsTrue(list.CheckHandForFullHouse());
        }

    }
}