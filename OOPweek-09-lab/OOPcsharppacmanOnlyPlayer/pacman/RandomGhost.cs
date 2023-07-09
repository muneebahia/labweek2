using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    class RandomGhost:ClassParentGhost
    {
        public GameDirection direction;
        public RandomGhost(char displaycharacter, GameCell cell) : base(displaycharacter, cell) { }
        public void setDirection()
        {
            int dir=rand();
            if(dir==0)
            {
                this.direction = GameDirection.Left;
            }
            if (dir == 1)
            {
                this.direction = GameDirection.Right;
            }
            if (dir == 2)
            {
                this.direction = GameDirection.Down;
            }
            if (dir == 3)
            {
                this.direction = GameDirection.Up;
            }
        }
        public override void checkdirection()
        {
            if (direction == GameDirection.Left)
            {
                direction = GameDirection.Right;
            }
            else if (direction == GameDirection.Right)
            {
                direction = GameDirection.Left;
            }
            if (direction == GameDirection.Up)
            {
                direction = GameDirection.Down;
            }
            else if (direction == GameDirection.Down)
            {
                direction = GameDirection.Up;
            }
        }
        public override GameCell Move()
        {
            setDirection();
            GameCell nextCell = this.CurrentCell.nextCell(direction);
            return nextCell;
        }
        public int rand()
        {
            Random rand = new Random();
            int value = rand.Next(4);
            return value;
        }
    }
}
