using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PacMan.GameGL
{
    class GamePacManPlayer : GameObject
    {
        private int lives;
        private int score;
       
        public GamePacManPlayer(Image image,GameCell startCell,int lives,int score):base (GameObjectType.PLAYER,image) {
            this.CurrentCell = startCell;
            this.Lives = lives;
            this.Score = score;
        }
        public int Lives { get => lives; set => lives = value; }
        public int Score { get => score; set => score = value; }

        public GameCell move(GameDirection direction) 
        {
            GameCell currentCell = this.CurrentCell;
            GameCell nextCell= currentCell.nextCell(direction);
            if(nextCell.CurrentGameObject.GameObjectType == GameObjectType.REWARD)
            {
                Score++;
            }
            this.CurrentCell = nextCell;
            if (currentCell != nextCell) {
                currentCell.setGameObject(Game.getBlankGameObject());

            }
            return nextCell;
        }

    }

    
}
