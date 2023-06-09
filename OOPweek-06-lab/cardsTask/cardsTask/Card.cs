using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardsTask
{
    internal class Card
    {
        private int value;
        /*  public int Value()
          {
              return value; 
          }*/
        private int suit;

        public int clubs = 1;
        public int diamonds = 2;
        public int spade = 3;
        public int heart = 4;
        public Card() { }
        public int getSuit()
        {
            return suit;
        }
        public int getValue()
        { return value; }

        public Card(int theSuit, int theValue)
        {
            this.suit = theSuit;
            this.value = theValue;

        }
        public string getSuitAsString()
        {
            if (this.suit == 1)
            {
                return "club";
            }
            if (this.suit == 2)
            {
                return "diamond";
            }
            if (this.suit == 3)
            {
                return "spade";
            }
            if (this.suit == 4)
            {
                return "heart";
            }
            return null;
        }

        public string getValueAsString()
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
            string value;
            value = this.value.ToString();
            return value;
        }
        public string valNsuit()
        {
            string valsuit = getValueAsString() + " of " + getSuitAsString();
            return valsuit;
        }
    }
}
