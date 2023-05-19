using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02
{
    class GameObj
    {
        public char[,] Shape=new char[5,3];
        public point StartingPoint;
        public Boundary Premises;
        public string Direction;
        public GameObj(char[,] Shape, point StartingPoint, string Direction, Boundary Premises)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction =Direction;
        }
        public GameObj()
        {
            this.StartingPoint.x = 0;
            this.StartingPoint.y = 0;

            this.Premises.TopLeft.x = 0;
            this.Premises.TopLeft.y = 0;

            this.Premises.TopRight.x = 0;
            this.Premises.TopRight.y = 90;

            this.Premises.BottomLeft.x = 90;
            this.Premises.BottomLeft.y = 0;

            this.Premises.BottomLeft.x = 90;
            this.Premises.BottomLeft.y = 90;
            this.Direction = "LeftToRight";
             this.Shape = new char[5, 3];
        }
        public  void draw()
        {
            for(int i=0;i<5;i++)
            {
                Console.SetCursorPosition(StartingPoint.x + i, StartingPoint.y);
            }
        }
    }
}
