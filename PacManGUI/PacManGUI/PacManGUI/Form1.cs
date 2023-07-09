﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacMan.GameGL;
using EZInput;
namespace PacManGUI
{
    public partial class Form1 : Form
    {
        GamePacManPlayer pacman;
        ClassHorizontalGhost hGhost;
        ClassVerticalGhostcs vGhost;
        RandomGhost rGhost;
        ChazingGhost CGhost;
        int lives = 20;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

       
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GameGrid grid = new GameGrid("maze.txt",29,62);
            Image pacManImage = Game.getGameObjectImage('P');
            GameCell startCell = grid.getCell(8, 10);
            pacman = new GamePacManPlayer(pacManImage, startCell,lives,score);

            Image hghost = Game.getGameObjectImage('H');
            GameCell startCellHor = grid.getCell(1, 34);
            hGhost = new ClassHorizontalGhost(hghost, startCellHor,pacman);

            Image vghost = Game.getGameObjectImage('V');
            GameCell startCellVer = grid.getCell(20,3);
            vGhost = new ClassVerticalGhostcs(vghost, startCellVer,pacman);

            Image rghost = Game.getGameObjectImage('R');
            GameCell startCellRan = grid.getCell(4,26);
            rGhost = new RandomGhost(rghost, startCellRan,pacman);

            Image cghost = Game.getGameObjectImage('C');
            GameCell startCellChaz = grid.getCell(9,38);
            CGhost = new ChazingGhost(cghost, startCellChaz,pacman);
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
            //        printCell(cell);
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
           
            if(Keyboard.IsKeyPressed(Key.LeftArrow)) {
                pacman.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow)){
                pacman.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow)){
                pacman.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow)){
                pacman.move(GameDirection.Down);
            }
            lblplayerlive.Text = "lives:" + pacman.Lives.ToString();
            if(pacman.Lives<=0)
            {
                this.gameLoop.Enabled = false;
                this.Close();
            }
            lblscore.Text="Score:"+pacman.Score.ToString();
            vGhost.Move(pacman);
            hGhost.Move(pacman);
            rGhost.Move(pacman);
            CGhost.Move(pacman);
            


        }
    }
}
