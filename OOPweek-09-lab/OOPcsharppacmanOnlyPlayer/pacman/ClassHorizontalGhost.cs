using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    class  ClassHorizontalGhost : ClassParentGhost
    {

        public GameDirection direction = GameDirection.Left;
        public ClassHorizontalGhost(char displaycharacter, GameCell cell) : base(displaycharacter, cell) { }
        public override GameCell Move()
        {
            GameCell nextCell = this.CurrentCell.nextCell(direction);
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
