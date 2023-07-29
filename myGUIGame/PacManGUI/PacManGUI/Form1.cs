using EZInput;
using PacMan.GameGL;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace PacManGUI
{
    public partial class Form1 : Form
    {
        GamePacManPlayer pacman;
        ClassHorizontalGhost hGhost;
        ClassVerticalGhostcs vGhost;
        RandomGhost rGhost;
        ChazingGhost CGhost;
        Form2 restart = new Form2();


        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt", 29, 62);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer(pacManImage, startCell, 5, 0);

            Image hghost = Game.getGameObjectImage('H');
            GameCell startCellHor = grid.getCell(1, 34);
            hGhost = new ClassHorizontalGhost(hghost, startCellHor, 1);

            Image vghost = Game.getGameObjectImage('V');
            GameCell startCellVer = grid.getCell(20, 3);
            vGhost = new ClassVerticalGhostcs(vghost, startCellVer, 40);

            Image rghost = Game.getGameObjectImage('R');
            GameCell startCellRan = grid.getCell(4, 26);
            rGhost = new RandomGhost(rghost, startCellRan, 50);

            Image cghost = Game.getGameObjectImage('C');
            GameCell startCellChaz = grid.getCell(9, 38);
            CGhost = new ChazingGhost(cghost, startCellChaz, pacman, 100);
            printMaze(grid);
        }



        void printMaze(GameGrid grid)
        {
            for (int x = 0; x < grid.Rows; x++)
            {

                for (int y = 0; y < grid.Cols; y++)
                {
                    GameCell cell = grid.getCell(x, y);
                    this.Controls.Add(cell.PictureBox);

                }

            }
        }

        static void printCell(GameCell cell)
        {
            Console.SetCursorPosition(cell.Y, cell.X);
            Console.Write(cell.CurrentGameObject.DisplayCharacter);
        }


        private void gameLoop_Tick(object sender, EventArgs e)
        {

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pacman.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                pacman.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                pacman.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                pacman.move(GameDirection.Down);
            }

            lblplayerlive.Text = "lives:" + pacman.Lives.ToString();
            if (pacman.Lives <= 0)
            {
                this.gameLoop.Enabled = false;
                this.Hide();
                restart.Show();
            }
            lblscore.Text = "Score:" + pacman.Score.ToString();

            if (vGhost.VEnemylives > 0)
            {
                vGhost.Move(pacman);
            }
            if (hGhost.Hlive > 0)
            {
                hGhost.Move(pacman);
            }
            if (rGhost.RandEnemylive > 0)
            {
                rGhost.Move(pacman);
            }
            if (CGhost.Clive > 0)
            {
                CGhost.Move(pacman);
            }






        }

        private void lblscore_Click(object sender, EventArgs e)
        {

        }
    }
}
