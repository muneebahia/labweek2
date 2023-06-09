using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_06task1_pd
{
    class Card
    {
        private int value;
        private int suit;

        public int clubs;
        public int diamonds ;
        public int spades ;
        public int hearts;

        public Card() { }

        public Card(int theValue,int theSuit)
        {
            this.value = theValue;
            this.suit = theSuit;
        }
        public string getSuitasString()
        { 
            if(this.suit==1)
            {
                return "club";
            }
            if (this.suit == 2)
            {
                return "diamonds";
            }

            if (this.suit == 3)
            {
                return "spades";
            }
            if (this.suit == 4)
            {
                return "hearts";
            }


            return null;
        }

        public string getValueasString()
        {
            string value = toString();
            if (this.value == 1)
            {
                return "ace";
            }
            if (this.value == 11)
            {
                return "jack";
            }

            if (this.value == 12)
            {
                return "queen";
            }
            if (this.value == 13)
            {
                return "king";
            }
            return value;

        }
        public string toString()
        {
            string val;
            val = this.value.ToString();
            return val;
        }

    }
}
