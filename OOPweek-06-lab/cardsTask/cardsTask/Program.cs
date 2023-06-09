using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cardsTask.UI;

namespace cardsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu menuu = new menu();
            //  Deck obj= new Deck();
            //  Card card = new Card();
            int choice = 0;
            do
            {
                choice = menu.main();
                if (choice == 1)
                {
                    bool gamerunning = true;
                    int score = 0;
                    Deck obj = new Deck();
                    obj.shuffle();
                    Card card = obj.dealCard();
                    while (gamerunning)
                    {
                        int remain_check = obj.cardsLeft();
                        Card card2 = obj.dealCard();
                        Console.WriteLine("*********************************");
                        Console.WriteLine(card.toString());
                        Console.WriteLine("");
                        Console.WriteLine("Remaining cards: " + remain_check);
                        Console.WriteLine("Enter 1 if next card is higher");
                        Console.WriteLine("Enter 2 if next card is lower");
                        int card_check = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (card_check == 1)
                        {
                            if (card2.getValue() >= card.getValue())
                            {
                                score++;
                                card = card2;
                            }
                            else
                            {
                                gamerunning = false;
                                Console.WriteLine("Sorry You loss. Press any key to continue");
                                Console.WriteLine("The card was " + card2.toString());
                                Console.WriteLine("Your score is : " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (card_check == 2)
                        {
                            if (card2.getValue() < card.getValue())
                            {
                                score++;
                                card = card2;
                            }
                            else
                            {
                                gamerunning = false;
                                Console.WriteLine("Sorry You loss. Press any key to continue");
                                Console.WriteLine("The card was " + card2.toString());
                                Console.WriteLine("Your score is : " + score);
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }
                        if (obj.cardsLeft() == 0 && card2 == null)
                        {
                            gamerunning = false;
                            Console.WriteLine("Congrats you have scored maximum");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    }

                }



            }
            while (choice != 2);
            // Console.ReadLine();
        }
    }
}
