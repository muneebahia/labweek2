using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
namespace PacManGUI
{
    public partial class Form2 : Form
    {
        GamePacManPlayer pacman;
        ClassHorizontalGhost hGhost;
        ClassVerticalGhostcs vGhost;
        RandomGhost rGhost;
        ChazingGhost CGhost;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnendgame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
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
    }
}
