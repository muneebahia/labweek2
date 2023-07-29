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
        private int verenemylives;

        public int VEnemylives { get => verenemylives; set => verenemylives = value; }

        public ClassVerticalGhostcs(Image img, GameCell cell, int live) : base(img, cell) {
            this.VEnemylives = live;
        }
            public override GameCell Move(GamePacManPlayer pc)
            {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                if(pc.Score<20)
                {
                    pc.Lives--;
                }
                if(pc.Score < 20)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    pc.Score -= 10;
                    verenemylives--;
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
