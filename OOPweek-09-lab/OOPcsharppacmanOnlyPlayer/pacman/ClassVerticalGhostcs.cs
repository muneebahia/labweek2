using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    class ClassVerticalGhostcs:ClassParentGhost
    {
        public GameDirection direction = GameDirection.Up;
        public ClassVerticalGhostcs(char displaycharacter, GameCell cell) : base(displaycharacter, cell) { }
        public override GameCell Move()
        {
            GameCell nextCell = this.CurrentCell.nextCell(direction);
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
