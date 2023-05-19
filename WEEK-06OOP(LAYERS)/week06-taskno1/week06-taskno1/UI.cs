using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week06_taskno1
{
    class UI
    {
        public static string menu()
        {
            string choice = null;
            Console.WriteLine("1-Make a Line");
            Console.WriteLine("2-Update the Begining Point");
            Console.WriteLine("3-Update the End Point");
            Console.WriteLine("4-Show begin Point");
            Console.WriteLine("5-Show End Point");
            Console.WriteLine("6-Get the Length of Line");
            Console.WriteLine("7-Get the Gradient of Line");
            Console.WriteLine("8-Find the distance of Begin Point from Zero Co-ordinate");
            Console.WriteLine("9-Find the distance of End Point from Zero Co-ordinate");
            Console.WriteLine("10-Exit");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice:");
            choice = Console.ReadLine();
            return choice;
        }
        public static myLine choice1()
        {
            Console.WriteLine("Enter the begining X-Co-ordinate of line ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the begining Y-Co-ordinate of line ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Ending X-Co-ordinate of line");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Ending Y-Co-ordinate of line");
            int y1 = int.Parse(Console.ReadLine());
            mypoint statingPt = new mypoint(x, y);
            mypoint endingPt = new mypoint(x1, y1);
            myLine Line = new myLine(statingPt, endingPt);
            return Line;
        }
        public static void printline(myLine Line)
        {
            Console.WriteLine("The coordinates of the Begining of the line are:" + "(" + Line.begin.x + "," + Line.begin.y + ")");
            Console.WriteLine("The coordinates of the Ending of the line are:" + "(" + Line.end.x + "," + Line.end.y + ")");
        }
        public static mypoint choice2()
        {
            Console.WriteLine("Enter new begining X-Co-ordinate of Line:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new begining Y-Co-ordinate of Line:");
            int y = int.Parse(Console.ReadLine());

            mypoint start = new mypoint(x, y);
            return start;

        }

        public static mypoint choice3()
        {
            Console.WriteLine("Enter new ending X-Co-ordinate of Line:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new ending Y-Co-ordinate of Line:");
            int y = int.Parse(Console.ReadLine());

            mypoint end = new mypoint(x, y);
            return end;

        }
        public static void printupdatestartingpoint(myLine Line)
        {
            Console.WriteLine("Line begining point are:" + "(" + Line.begin.x + "," + Line.begin.y + ")");
        }
        public static void printupdateendingpoint(myLine Line)
        {
            Console.WriteLine("Line ending point are:" + "(" + Line.end.x + "," + Line.end.y + ")");
        }

        public static void choice6(double length)
        {
            Console.WriteLine("Length of the Line is:" + " " + length);
        }
        public static void choice7(double gradient)
        {
            Console.WriteLine("Gradienth of the Line is:" + " " + gradient);
        }
        public static void printbeginingdistancefromzero(double Bdistance)
        {
            Console.WriteLine("Distance of the beining from the zero is:" + " " + Bdistance);

        }
        public static void printendingdistancefromzero(double Edistance)
        {
            Console.WriteLine("Distance of the Ending from the zero is:" + " " + Edistance);
        }

    }
}
