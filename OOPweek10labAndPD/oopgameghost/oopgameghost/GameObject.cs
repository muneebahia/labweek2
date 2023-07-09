using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgameghost
{
    class GameObject
    {
        public char DisplayCharacter;
        public GameCell CurrentCell;
        public GameObjectType GameObjectType;
        public GameObject()
        {

        }
        public GameObject(GameObjectType type,char DisplayCharacter)
        {
            GameObjectType = type;
            this.DisplayCharacter = DisplayCharacter;

        }
        public static GameObjectType GetGameObjectType(char displayCharacter)
        {
            if (displayCharacter == '|' || displayCharacter == '#' || displayCharacter == '%')
            {
                return GameObjectType.WALL;
            }
            if (displayCharacter == 'P')
            {
                return GameObjectType.PLAYER;
            }
            return GameObjectType.NONE;
        }
    }
}
