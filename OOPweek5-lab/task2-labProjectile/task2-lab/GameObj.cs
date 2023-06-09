using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02
{
    class GameObj
    {
        public char[,] Shape = new char[5, 3];
        public point StartingPoint;
        public Boundary Premises;
        public string Direction;
        public int count;
        public GameObj(char[,] Shape, point StartingPoint, string Direction, Boundary Premises)
        {
            this.Shape = Shape;
            this.StartingPoint = StartingPoint;
            this.Premises = Premises;
            this.Direction = Direction;
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
        public void draw()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                Console.SetCursorPosition(StartingPoint.x+j, StartingPoint.y + i);
                    Console.Write(Shape[i, j]);
                }
            }
        }
        public void erase()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                Console.SetCursorPosition(StartingPoint.x + j, StartingPoint.y + i);
                    Console.Write(" ");
                }
            }


        }
        public void moveLeftToRight()
        {
            if(Direction== "LeftToRight")
            {
                if(this.StartingPoint.getX() < this.Premises.TopRight.x || this.StartingPoint.getX() < this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX()+1);
                }
            }
        }

        public void moveRightToLeft()
        {
            if (Direction == "RightToLeft")
            {
                if (this.StartingPoint.getX() > this.Premises.TopRight.x || this.StartingPoint.getX() > this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() - 1);
                }
            }
        }

        public void moveDiagonally()
        {
            if (Direction == "diagonal")
            {
                if (this.StartingPoint.getX() < this.Premises.BottomRight.x || this.StartingPoint.getX() > this.Premises.TopRight.y)
                {
                    this.StartingPoint.setX(StartingPoint.getX() + 1);
                    this.StartingPoint.setY(StartingPoint.getY() + 1);
                }
            }
        }
        public void movePatrol()
        {
            if ((this.Direction == "patrol"))
            {
                if (this.Direction == "RightToLeft")
                {
                    if (this.StartingPoint.x > Premises.TopRight.x && this.StartingPoint.x < Premises.TopLeft.x)
                    {
                        StartingPoint.x--;
                    }
                }
                else
                {
                    Direction = "LeftToRight";
                }

                if (Direction == "LeftToRight")
                {
                    if (this.StartingPoint.getX() < Premises.TopRight.x && this.StartingPoint.getX() > Premises.TopLeft.x)
                    {
                        StartingPoint.x++;
                    }
                }
                else
                {
                    this.Direction = "RightToLeft";
                }
            }
        }
        public void move()
        {
            if (this.Direction == "LeftToRight")
            {
                moveLeftToRight();
            }
            else if (this.Direction == "RightToLeft")
            {
                moveRightToLeft();
            }
            else if (this.Direction == "diagonal")
            {
                moveDiagonally();
            }
            else if (this.Direction == "projectile")
            {

                moveProjectile();
            }
            else if (this.Direction == "patrol")
            {
                movePatrol();
            }
            }

            public void towardstopright5()
        {

            if (this.StartingPoint.getX() < this.Premises.TopRight.y)
            {
                this.StartingPoint.setY(StartingPoint.getY() - 1);
                this.count++;
            }

        }
        public void moverightpro2()
        {
            if (this.StartingPoint.getX() < Premises.TopRight.y && this.StartingPoint.getX() > Premises.TopLeft.x)
            {

                this.StartingPoint.setX(StartingPoint.getX() + 1);
                this.count++;
            }

        }
        public void movebottom4()
        {
            if (this.StartingPoint.getY() < this.Premises.BottomLeft.y)
            {
                this.StartingPoint.setX(this.StartingPoint.getX() + 1);
                this.StartingPoint.setY(this.StartingPoint.getY() + 1);
                this.count++;
            }
        }
        public void moveProjectile()
        {
            if (this.Direction == "projectile")
            {
                if (count < 5)
                {
                    towardstopright5();
                }
                if (count >= 5 && count <= 12)
                {
                    moverightpro2();
                }
                if (count > 12 && count <= 16)
                {
                    movebottom4();
                }

            }
        }
    }
}
