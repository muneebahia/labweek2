using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacMan.GameGL
{
        class ClassVerticalGhostcs : ClassParentGhost
        {
            public GameDirection direction = GameDirection.Up;
            
            public ClassVerticalGhostcs(Image img, GameCell cell, GamePacManPlayer pcman) : base(img, cell) {
            
        }
            public override GameCell Move(GamePacManPlayer pc)
            {
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
            public override void checkdirection()
            {
                if (direction == GameDirection.Up)
                {
                    direction = GameDirection.Down;
                }
                else if (direction == GameDirection.Down)
                {
                    direction = GameDirection.Up;
                }
            }
        }
}
