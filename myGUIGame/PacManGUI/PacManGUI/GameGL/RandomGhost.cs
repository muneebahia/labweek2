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
            private int randEnemylive=20;

        public int RandEnemylive { get => randEnemylive; set => randEnemylive = value; }

        public RandomGhost(Image img, GameCell cell,int live) : base(img, cell) { this.RandEnemylive = live; }
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
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                if (pc.Score < 20)
                {
                    pc.Lives--;
                }
                if (pc.Score < 20)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    pc.Score -= 10;
                    this.RandEnemylive--;
                }
               
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
