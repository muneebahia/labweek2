using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cardsTask.UI
{

    class menu
    {
        public int menuu()
        {
            int choice = 0;
            Console.WriteLine("1. Deal a card");
            Console.WriteLine("2. Shuffle card");
            Console.WriteLine("3. check suit ");
            Console.WriteLine("4. check value");
            Console.WriteLine("5. cards left");
            Console.WriteLine("6. view suit along with value");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static int main()
        {
            Console.WriteLine("Enter 1 to play game");
            Console.WriteLine("Enter 2 to exit game");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public void viewSuit(string suit)
        {
            Console.WriteLine("The suit is : " + suit);
        }
        public void viewValue(string value)
        {
            Console.WriteLine("The value is : " + value);
        }
        public void viewValuenSuit(string valSuit)
        {
            Console.WriteLine("The value and suit is : " + valSuit);
        }
        public void cardLeft(int count)
        {
            Console.WriteLine("The " + count + " cards left");
        }
    }
}
