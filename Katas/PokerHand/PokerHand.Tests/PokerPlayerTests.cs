namespace PokerHand.Tests
{
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
            var game = new PokerGame("name1", "name2");
        }
    }
}