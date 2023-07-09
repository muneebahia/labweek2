using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace oopgameghost
{
    class GameGrid
    {
        public int row;
        public int cols;
        public GameCell[,] GameCells;
        public GameGrid(string fileName, int rows, int coloumns)
        {
            row = rows;
            cols = coloumns;
            GameCells = new GameCell[rows, coloumns];
        }

        public void loadGrid(string fileName)
        {
            StreamReader file = new StreamReader(fileName);
            string line = " ";
            for (int i = 0; i<row; i++)
            {
                line = file.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    GameCell cellInitialize = new GameCell(i, j, this);
                    char Character = line[j];
                    GameObjectType type = GameObject.GetGameObjectType(Character);
                    GameObject gameObject = new GameObject(type, Character);
                    cellInitialize.currentGameObject = gameObject;
                    GameCells[i, j] = cellInitialize;
                }
            }
        }
        public GameCell getCell(int x,int y)
        {
            return GameCells[x, y];
        }
    }
}
