using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_06task1_pd
{
    class Deck
    {
        public List<Card> cards = new List<Card>();
        Card obj = new Card();
        public Deck()
        {
            cards = new List<Card>();


            for (int x = 1; x <= 4; x++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card(value, x));
                

            }
        }
        public void shuffle()
        {
                Random random = new Random();
        }
        public int CardsLeft()
        {

        }
        public Card dealcard()
        {

        }

    }
}
