using System;

namespace Blackjack
{
    public class Card
    {
        public int value { get; }
        public string FaceValue { get; }
        public string Suit { get; }

        public Card(int cardnumber)
        {
            int tempval = (cardnumber % 13) + 1;
            switch (tempval)
            {
                case 1:
                    FaceValue = "Ace";
                    break;

                case 11:
                    FaceValue = "Jack";
                    break;

                case 12:
                    FaceValue = "Queen";
                    break;

                case 13:
                    FaceValue = "King";
                    break;
                default:
                    FaceValue = tempval.ToString();
                    break;

            }

            if (tempval > 10)
            {
                value = 10;
            }
            else
            {
                value = tempval;
            }

            string[] suits = new string[] { "Spades", "Diamonds", "Hearts", "Clubs" };
            Suit = suits[cardnumber / 13];
        }
        public override string ToString()
        {
            return String.Format("{0} of {1}", FaceValue, Suit);
        }
    }
}
