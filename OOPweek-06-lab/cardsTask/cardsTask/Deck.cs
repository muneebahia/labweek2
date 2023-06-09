using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsTask
{
    internal class Deck
    {
        public List<Card> cards;
        Card car = new Card();
        public Deck()
        {
            cards = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    cards.Add(new Card(i, j));
                }
            }
        }

        public void shuffle()
        {
            Random rand = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rand.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }

        }
        public int cardsLeft()
        {
            return cards.Count;
        }
        public Card dealCard()
        {
            return cards[6];


        }
    }
}
