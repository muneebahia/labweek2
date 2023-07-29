using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacMan.GameGL
{
   
        abstract class ClassParentGhost : GameObject
        {
            public ClassParentGhost(Image img, GameCell startCell) : base(GameObjectType.ENEMY, img)
            {
                this.CurrentCell = startCell;
            }
            public abstract GameCell Move(GamePacManPlayer pc);
            public abstract void checkdirection();

        }
    
}
