namespace PokerHand
{
    using System.Collections.Generic;
    using System.Linq;
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

        public static bool CheckHandForValueMatches(this List<Card> hand, int cardCountToCheck)
        {
            var cardValues = new List<CardValue>();

            hand.ForEach(c => cardValues.Add(c.Value));

            return cardValues.Distinct().Count() == cardCountToCheck;
        }

        public static bool CheckHandForFullHouse(this List<Card> hand)
        {
            var initialCardValue = hand[0].Value;
            int matchCount = 0;

            hand.ForEach(card =>
            {
                if (initialCardValue == card.Value)
                {
                    matchCount++;
                }
                else
                {
                    if (matchCount == 3 || matchCount == 2)
                    {
                        initialCardValue = card.Value;
                    }
                }
                
            });

            return matchCount == 4;
        }

        public static bool CheckHandForFlush(this List<Card> hand)
        {
            var suits = new List<Suit>();

            hand.ForEach(card => suits.Add(card.Suit));

            return suits.Distinct().Count() == 1;
        }

        public static bool CheckHandForStraight(this List<Card> hand)
        {
            var initialCardValue = hand[0].Value;
            var matchCount = 0;

            hand.ForEach(card =>
            {
                if (initialCardValue == card.Value)
                {
                    matchCount++;
                }

                initialCardValue--;
            });

            return matchCount == hand.Count;
        }

        public static void SortValues(this List<Card> hand)
        {
            hand.Sort((card, nextCard) => nextCard.Value.CompareTo(card.Value));
        }
    }
}