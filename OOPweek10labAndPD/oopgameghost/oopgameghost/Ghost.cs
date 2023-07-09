using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgameghost
{
   abstract class Ghost:GameObject
    {
        public Ghost(char DisplayCharacter,GameCell startcell):base(GameObjectType.PLAYER, DisplayCharacter)
        {
            this.CurrentCell = startcell;
        }
      public  abstract GameCell move();
    }
}
