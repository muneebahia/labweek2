using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
     abstract class ClassParentGhost : GameObject
    {
        public ClassParentGhost(char displayCharacter, GameCell startCell) : base(GameObjectType.ENEMY, displayCharacter)
        {
            this.CurrentCell = startCell;
        }
        public abstract GameCell Move();
        public abstract void checkdirection();

    }
}
