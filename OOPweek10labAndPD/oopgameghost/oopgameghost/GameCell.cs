using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgameghost
{
    class GameCell
    {
        public int x;
        public int y;
        public GameObject currentGameObject;
        public GameGrid gameGrid;
        public GameCell(int x,int y,GameGrid grid)
        {
            this.x = x;
            this.y = y;
            gameGrid = grid;
        }
        public GameCell nextCell(GameDirection direction)
        {
            if(direction==GameDirection.Right)
            {
                if(this.x<gameGrid.cols-1)
                {
                    GameCell nextCell = gameGrid.getCell(x+1, y);
                    if (nextCell.currentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nextCell;
                    }
                    else if (nextCell.currentGameObject.GameObjectType == GameObjectType.WALL)
                    {
                        direction = GameDirection.Left;
                    }
                    else if(nextCell.currentGameObject.GameObjectType != GameObjectType.PLAYER)
                    {
                        return nextCell;
                    }
                }
            }
            if (direction == GameDirection.Left)
            {
                if (this.x >0)
                {
                    GameCell nextCell = gameGrid.getCell(x-1, y);
                    if (nextCell.currentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nextCell;
                    }
                   else if (nextCell.currentGameObject.GameObjectType == GameObjectType.WALL)
                    {
                        direction = GameDirection.Right;
                    }
                    else if (nextCell.currentGameObject.GameObjectType != GameObjectType.PLAYER)
                    {
                        return nextCell;
                    }
                }
            }
            if (direction == GameDirection.Up)
            {
                if (this.y>0)
                {
                    GameCell nextCell = gameGrid.getCell(x, y-1);
                    if (nextCell.currentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nextCell;
                    }
                    else if (nextCell.currentGameObject.GameObjectType == GameObjectType.WALL)
                    {
                        direction = GameDirection.Down;
                    }
                    else if (nextCell.currentGameObject.GameObjectType != GameObjectType.PLAYER)
                    {
                        return nextCell;
                    }
                }
            }
            if (direction == GameDirection.Down)
            {
                if (this.x < gameGrid.row - 1)
                {
                    GameCell nextCell = gameGrid.getCell(x, y+1);
                    if (nextCell.currentGameObject.GameObjectType != GameObjectType.WALL)
                    {
                        return nextCell;
                    }
                    else if (nextCell.currentGameObject.GameObjectType == GameObjectType.WALL)
                    {
                        direction = GameDirection.Up;
                    }
                    else if (nextCell.currentGameObject.GameObjectType != GameObjectType.PLAYER)
                    {
                        return nextCell;
                    }
                }
            }
            return this;
        }
    }
}
