using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacMan.GameGL
{
    class ChazingGhost : ClassParentGhost
    {
        public GameDirection direction = GameDirection.Left;
        public GameObject player;
        private int clive;

        public int Clive { get => clive; set => clive = value; }

        public ChazingGhost(Image img, GameCell cell, GameObject player, int live) : base(img, cell)
        {
            this.player = player;
            this.Clive = live;
        }
        public override void checkdirection()
        {
            if (direction == GameDirection.Left)
            {
                direction = GameDirection.Right;
            }
            else if (direction == GameDirection.Right)
            {
                direction = GameDirection.Left;
            }
            if (direction == GameDirection.Up)
            {
                direction = GameDirection.Down;
            }
            else if (direction == GameDirection.Down)
            {
                direction = GameDirection.Up;
            }
        }
        public override GameCell Move(GamePacManPlayer pc)
        {
            chkNextDistanceVal();
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell = currentCell.nextCell(direction);
            if (nextCell.CurrentGameObject.GameObjectType == GameObjectType.PLAYER)
            {
                if (pc.Score < 20)
                {
                    pc.Lives--;
                }
                if (pc.Score < 20)
                {
                    currentCell.setGameObject(Game.getBlankGameObject());
                    pc.Score -= 10;
                    Clive--;
                }
            }
            this.CurrentCell = nextCell;
            if (currentCell == nextCell)
            {
                checkdirection();
            }
            if (currentCell != nextCell && (nextCell.CurrentGameObject?.GameObjectType != GameObjectType.WALL))
            {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }

        public double calculateDistance(GameCell nextCell)
        {
            return Math.Sqrt(Math.Pow(player.CurrentCell.X - nextCell.X, 2) + Math.Pow(player.CurrentCell.Y - nextCell.Y, 2));
        }

        public void chkNextDistanceVal()
        {
            double[] distance = new double[4] { 10000, 10000, 10000, 10000 };
            if (this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
              this.CurrentCell.nextCell(GameDirection.Left).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[0] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Left));
            }
            if (this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject?.GameObjectType == GameObjectType.NONE ||
             this.CurrentCell.nextCell(GameDirection.Right).CurrentGameObject?.GameObjectType == GameObjectType.REWARD)
            {
                distance[1] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Right));
            }
            if (this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
            this.CurrentCell.nextCell(GameDirection.Up).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[2] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Up));
            }
            if (this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.NONE ||
            this.CurrentCell.nextCell(GameDirection.Down).CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                distance[3] = calculateDistance(this.CurrentCell.nextCell(GameDirection.Down));
            }
            if (distance[0] <= distance[1] && distance[0] <= distance[2] && distance[0] <= distance[3])
            {
                this.direction = GameDirection.Left;

            }
            else if (distance[1] <= distance[0] && distance[1] <= distance[2] && distance[1] <= distance[3])
            {
                this.direction = GameDirection.Right;

            }
            else if (distance[2] <= distance[0] && distance[2] <= distance[1] && distance[2] <= distance[3])
            {
                this.direction = GameDirection.Up;

            }
            else if (distance[3] <= distance[0] && distance[3] <= distance[1] && distance[3] <= distance[2])
            {
                this.direction = GameDirection.Down;

            }
            else
            {
                this.direction = GameDirection.Right;
            }

        }

    }
}
