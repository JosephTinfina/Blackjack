using System;
using System.Collections.Generic;

namespace Blackjack
{
    internal class Hand
    {
        public List<Card> cards;


        public Hand()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
        public int GetValue()
        {
            int total = 0;
            foreach (Card card in cards)
            {
                total = total + card.value;
            }

            return total;
        }
        public bool bust()
        {
            if (GetValue() > 21)
            { return true; }
            else { return false; }
        }

        public Card showdealercard()
        {
            return cards[0];
        }

        public void showCards()
        {
            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine($"Your running total is {GetValue()}");
        }
    }
}

