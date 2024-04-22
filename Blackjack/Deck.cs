using System;
using System.Collections.Generic;

namespace Blackjack
{
    public class Deck 
    {
        List<Card> cards;
        public Deck()
        {
            cards = new List<Card>();
            for (int i = 0; i < 52; i++)
            {
                Card card = new Card(i);
                cards.Add(card);
            }
            shuffle();
        }
        public Card dealACard()
        {
            Card temp = cards[0];
            cards.RemoveAt(0);
            return temp;
        }
        public void shuffle()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                int selected = rand.Next(cards.Count);
                Card temp = cards[selected];
                cards.RemoveAt(selected);
                cards.Add(temp);
            }
        }
        public void show()
        {
            foreach (Card card in cards)
            { Console.WriteLine(card); }
        }
    }
}

