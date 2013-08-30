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
                    case CardValue.Two:
                        stringBuilder.Append("2");
                        break;
                    case CardValue.Three:
                        stringBuilder.Append("3");
                        break;
                    case CardValue.Four:
                        stringBuilder.Append("4");
                        break;
                    case CardValue.Five:
                        stringBuilder.Append("5");
                        break;
                    case CardValue.Six:
                        stringBuilder.Append("6");
                        break;
                    case CardValue.Seven:
                        stringBuilder.Append("7");
                        break;
                    case CardValue.Eight:
                        stringBuilder.Append("8");
                        break;
                    case CardValue.Nine:
                        stringBuilder.Append("9");
                        break;
                    case CardValue.Ten:
                        stringBuilder.Append("T");
                        break;
                    case CardValue.Jack:
                        stringBuilder.Append("J");
                        break;
                    case CardValue.Queen:
                        stringBuilder.Append("Q");
                        break;
                    case CardValue.King:
                        stringBuilder.Append("K");
                        break;
                    case CardValue.Ace:
                        stringBuilder.Append("A");
                        break;
                    default:
                        stringBuilder.Append(string.Empty);
                        break;
                }

                switch (card.Suit)
                {
                    case Suit.Clubs:
                        stringBuilder.Append("C");
                        break;
                    case Suit.Diamonds:
                        stringBuilder.Append("D");
                        break;
                    case Suit.Hearts:
                        stringBuilder.Append("H");
                        break;
                    case Suit.Spades:
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