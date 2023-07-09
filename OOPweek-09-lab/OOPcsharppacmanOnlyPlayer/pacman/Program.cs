using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EZInput;
using pacman;
using pacman.Classes;

namespace PacMan
{
    class Program
    {
        static void Main(string[] args)
        {
            GameGrid grid = new GameGrid("maze.txt", 24, 71);
            GameCell start = new GameCell(12, 22, grid);
            PacmanPlayer pacman = new PacmanPlayer('p', start);
            ClassHorizontalGhost hghost = new ClassHorizontalGhost('G', new GameCell(1, 34, grid));
            ClassVerticalGhostcs vghost = new ClassVerticalGhostcs('V', new GameCell(15, 50, grid));
            RandomGhost Rghost = new RandomGhost('R', new GameCell(18, 18, grid));
            ChazingGhost Cghost = new ChazingGhost('C', new GameCell(4, 25, grid), pacman);
            printMaze(grid);
            printGameObject(pacman);
            printGameObject(hghost);
            printGameObject(vghost);
            printGameObject(Rghost);
            printGameObject(Cghost);


            bool gameRunning = true;
            while (gameRunning)
            {
                Thread.Sleep(90);
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    moveGameObject(pacman, GameDirection.Up);
                }

                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    
                    moveGameObject(pacman, GameDirection.Down);
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    moveGameObject(pacman, GameDirection.Right);
                }

                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    moveGameObject(pacman, GameDirection.Left);
                }
                GameCell nextcell = hghost.Move();
                moveghosts(hghost, nextcell);

                GameCell nextCell = vghost.Move();
                moveghosts(vghost, nextCell);

                GameCell nextCellR = Rghost.Move();
                moveghosts(Rghost, nextCellR);

                GameCell nextCellC = Cghost.Move();
                moveghosts(Cghost, nextCellC);

            }
        }
        static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
        {
            gameCell.CurrentGameObject = newGameObject;
            Console.SetCursorPosition(gameCell.y, gameCell.x);
            Console.Write(newGameObject.DisplayCharacter);
        }
        static void printGameObject(GameObject gameObject)
        {
            Console.SetCursorPosition(gameObject.CurrentCell.y, gameObject.CurrentCell.x);
            Console.Write(gameObject.DisplayCharacter);

        }
        static void moveGameObject(GameObject gameObject, GameDirection direction)
        {
            GameCell nextCell = gameObject.move(direction);
          
            if (nextCell != null)
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                GameCell currentCell = gameObject.CurrentCell;
                clearGameCellContent(currentCell, newGO);
                gameObject.CurrentCell = nextCell;
                printGameObject(gameObject);
            }
        }
        static void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {
                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.GetCell(x, y);
                    printCell(cell);
                }
            }
        }
        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.y, cell.x);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }
        public static void moveghosts(ClassParentGhost g, GameCell nextCell)
        {
            if(g.CurrentCell==nextCell)
            { g.checkdirection(); }
            if (nextCell != null && nextCell.CurrentGameObject?.GameObjectType != GameObjectType.WALL)
                //&& nextCell.CurrentGameObject.GameObjectType != GameObjectType.REWARD)
            {
                GameObject newGO = new GameObject(GameObjectType.NONE, ' ');
                GameCell currentCell = g.CurrentCell;
                Program.clearGameCellContent(currentCell, newGO);
                g.CurrentCell = nextCell;
                Program.printGameObject(g);
            }

            else
            {
                g.checkdirection();
            }
        }

    }
}