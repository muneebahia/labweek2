using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacMan.GameGL
{
        class RandomGhost : ClassParentGhost
        {
            public GameDirection direction;
            public RandomGhost(Image img, GameCell cell, GamePacManPlayer pc) : base(img, cell) { }
            public void setDirection()
            {
                int dir = rand();
                if (dir == 0)
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
            public override GameCell Move(GamePacManPlayer pc)
            {
                setDirection();
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (this.CurrentCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                pc.Lives--;
            }
            this.CurrentCell = nextCell;
            if (currentCell == nextCell)
            {
                checkdirection();
            }
            if (currentCell != nextCell && (nextCell.CurrentGameObject?.GameObjectType != GameObjectType.WALL))
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
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
