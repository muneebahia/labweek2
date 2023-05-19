using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week06_taskno1
{
    class Program
    {
        static void Main(string[] args)
        {
            myLine Line = new myLine();
            mypoint cordinates = new mypoint();
            string choice = null;
            do
            {
                choice = UI.menu();
                if (choice == "1")
                {
                    Console.Clear();
                    Line = UI.choice1();
                    UI.printline(Line);
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    cordinates = UI.choice2();
                    Line.setBegin(cordinates);
                }

                else if (choice == "3")
                {
                    Console.Clear();
                    cordinates = UI.choice3();
                    Line.setEnd(cordinates);
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    UI.printupdatestartingpoint(Line);

                }
                else if (choice == "5")
                {
                    Console.Clear();
                    UI.printupdateendingpoint(Line);

                }
                else if (choice == "6")
                {
                    Console.Clear();
                    double length = Line.getLength();
                    UI.choice6(length);
                }
                else if (choice == "7")
                {
                    Console.Clear();
                    double gradient = Line.getGradient();
                    UI.choice6(gradient);
                }

                else if (choice == "8")
                {
                    Console.Clear();

                    double Bdistancefromzero = Line.distanceWithCord();
                    UI.printbeginingdistancefromzero(Bdistancefromzero);
                }
                else if (choice == "9")
                {
                    Console.Clear();

                    double Edistancefromzero = Line.distanceFromZero();
                    UI.printendingdistancefromzero(Edistancefromzero);
                }


            } while (choice != "10");

        }
    }
}
