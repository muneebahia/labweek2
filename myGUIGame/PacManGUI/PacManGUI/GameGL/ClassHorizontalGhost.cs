using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacMan.GameGL
{
    class ClassHorizontalGhost:ClassParentGhost
    {
        public GameDirection direction = GameDirection.Left;
        private int hlive;


        public int Hlive { get => hlive; set => hlive = value; }

        public ClassHorizontalGhost(Image img, GameCell cell, int live) : base(img, cell) { this.Hlive = live; }
        public override GameCell Move(GamePacManPlayer pc)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                if (pc.Score < 20)
                {
                    pc.Lives--;
                }
                if (pc.Score > 20)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    pc.Score -= 10;
                    Hlive--;
                }
            }
            this.CurrentCell = nextCell;
            if(currentCell==nextCell)
            {
                checkdirection();
            }
            if (currentCell != nextCell && (nextCell.CurrentGameObject?.GameObjectType!=GameObjectType.WALL))
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
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
        }
    }
}
