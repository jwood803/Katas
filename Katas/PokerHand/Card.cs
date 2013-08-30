using System;
namespace PokerHand
{
    public class Card
    {
        public CardValue Value { get; set; }
        public Suit Suit { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", this.Value, this.Suit);
        }
    }
}