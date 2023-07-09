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
        public ClassHorizontalGhost(Image img, GameCell cell, GamePacManPlayer pc) : base(img, cell) { }
        public override GameCell Move(GamePacManPlayer pc)
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (this.CurrentCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                pc.Lives--;
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
