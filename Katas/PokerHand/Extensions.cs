namespace PokerHand
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class Extensions
    {
        public static string DisplayHand(this PokerPlayer player)
        {
            var stringBuilder = new StringBuilder();

            player.Cards.ForEach(card =>
            {
                switch (card.Value)
                {
                    case CardValue.TWO:
                        stringBuilder.Append("2");
                        break;
                    case CardValue.THREE:
                        stringBuilder.Append("3");
                        break;
                    case CardValue.FOUR:
                        stringBuilder.Append("4");
                        break;
                    case CardValue.FIVE:
                        stringBuilder.Append("5");
                        break;
                    case CardValue.SIX:
                        stringBuilder.Append("6");
                        break;
                    case CardValue.SEVEN:
                        stringBuilder.Append("7");
                        break;
                    case CardValue.EIGHT:
                        stringBuilder.Append("8");
                        break;
                    case CardValue.NINE:
                        stringBuilder.Append("9");
                        break;
                    case CardValue.TEN:
                        stringBuilder.Append("T");
                        break;
                    case CardValue.JACK:
                        stringBuilder.Append("J");
                        break;
                    case CardValue.QUEEN:
                        stringBuilder.Append("Q");
                        break;
                    case CardValue.KING:
                        stringBuilder.Append("K");
                        break;
                    case CardValue.ACE:
                        stringBuilder.Append("A");
                        break;
                    default:
                        stringBuilder.Append(string.Empty);
                        break;
                }

                switch (card.Suit)
                {
                    case Suit.CLUBS:
                        stringBuilder.Append("C");
                        break;
                    case Suit.DIAMONDS:
                        stringBuilder.Append("D");
                        break;
                    case Suit.HEARTS:
                        stringBuilder.Append("H");
                        break;
                    case Suit.SPADES:
                        stringBuilder.Append("S");
                        break;
                    default:
                        stringBuilder.Append(string.Empty);
                        break;
                }

                stringBuilder.Append(" ");
            });

            return stringBuilder.ToString();
        }

        public static void ForAll<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (var item in sequence)
            {
                action(item);
            }
        }
    }
}