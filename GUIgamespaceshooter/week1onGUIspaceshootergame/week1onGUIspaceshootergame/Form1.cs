using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;

namespace week1onGUIspaceshootergame
{
    public partial class Form1 : Form
    {
        PictureBox player = new PictureBox();
        List<PictureBox> fires = new List<PictureBox>();
        List<PictureBox> enemyfires = new List<PictureBox>();
        List<PictureBox> meteorlist = new List<PictureBox>();
        PictureBox enemyBlack;
        PictureBox enemyBlue;
        PictureBox meteorbox;
        int score = 0;
        string enemyBlackDirection = "MovingLeft";
        string enemyBlueDirection = "MovingRight";
        int enemyBlackLastTimeOfFire = 0;
        int enemyBlackTimeOfFire=5;
        int enemyBlueLastTimeOfFire = 0;
        int enemyBlueTimeOfFire = 9;
        int meteorGenerationTime = 8;
        int lastmeteorGenerationTime = 0;
        bool isBlacklive = true;
        bool isBlueLive = true;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enemyBlack = createEnemy(Properties.Resources.enemy);
            enemyBlue = createEnemy(Properties.Resources.enemy2);
            this.Controls.Add(enemyBlack);
            this.Controls.Add(enemyBlue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {

                pictureBox1.Left += 25;
                playerHealthbar.Left += 25;
            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                pictureBox1.Left -= 25;
                playerHealthbar.Left -= 25;
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                Image img = Properties.Resources.bullet;
                PictureBox bullet = new PictureBox();
                bullet.Image = img;
                bullet.Width = img.Width;
                bullet.Height = img.Height;
                bullet.BackColor = Color.Transparent;
                bullet.Left = pictureBox1.Left + (pictureBox1.Width / 2) - 5;
                bullet.Top = pictureBox1.Top;
                this.Controls.Add(bullet);
                fires.Add(bullet);
            }
            /*  foreach (var bullet in fires)
              {
                  bullet.Top = bullet.Top - 20;
              }*/
            for (int i = 0; i < fires.Count; i++)
            {
                fires[i].Top = fires[i].Top - 50;
                if (fires[i].Top < 0)
                {
                    this.Controls.Remove(fires[i]);
                    fires.Remove(fires[i]);
                }
            }
            if (isBlacklive)
            {
                moveEnemy(enemyBlack, ref enemyBlackDirection);
                enemyBlackLastTimeOfFire++;
                if (enemyBlackLastTimeOfFire >= enemyBlackTimeOfFire)
                {
                    Image fireimg = Properties.Resources.enemyBullet;
                    PictureBox pbFire = createFire(fireimg, enemyBlack);
                    enemyfires.Add(pbFire);
                    this.Controls.Add(pbFire);
                    enemyBlackLastTimeOfFire = 0;
                }
            }
          if(isBlueLive)
            {
                moveEnemy(enemyBlue, ref enemyBlueDirection);
                enemyBlueLastTimeOfFire++;
                if (enemyBlueLastTimeOfFire >= enemyBlueTimeOfFire)
                {
                    Image fireimg = Properties.Resources.enemyBullet;
                    PictureBox pbFire = createFire(fireimg, enemyBlue);
                    enemyfires.Add(pbFire);
                    this.Controls.Add(pbFire);
                    enemyBlueLastTimeOfFire = 0;
                }

            }
            // gamewin
            if (isBlacklive == false&&isBlueLive==false)
            {
                timergameloop.Enabled = false;
                MessageBox.Show("You Won");
                this.Close();
            }

            // meteor generation
            lastmeteorGenerationTime++;
            if (lastmeteorGenerationTime >= meteorGenerationTime)
            {
                Image meteorimg = Properties.Resources.meteor;
                PictureBox pbmeteor = createMeteor(meteorimg, meteorbox);
                meteorlist.Add(pbmeteor);
                this.Controls.Add(pbmeteor);
                lastmeteorGenerationTime = 0;

            }
           foreach(PictureBox meteor in meteorlist)
            {
                movemeteor(meteor);
            }
           //remove enemy fire
            for (int i=0;i<enemyfires.Count;i++)
            {
                if(enemyfires[i].Top>this.Height)
                {
                    enemyfires.Remove(enemyfires[i]);
                  
                    
                }
            }
            foreach(PictureBox bullets in enemyfires)
            {
                bullets.Top = bullets.Top + 20;
            }
            for(int i = 0; i < enemyfires.Count; i++)
            {
                if(enemyfires[i].Bounds.IntersectsWith(pictureBox1.Bounds))
                {
                    if(playerHealthbar.Value>0 && enemyfires[i].Bounds.IntersectsWith(playerHealthbar.Bounds))
                    {
                        playerHealthbar.Value = playerHealthbar.Value - 5;
                        this.Controls.Remove(enemyfires[i]);
                        enemyfires.Remove(enemyfires[i]);
                    }
                  
                }
            }
            //destroying enemyblack
            for(int i = 0; i < fires.Count; i++)
            {
                if(fires[i].Bounds.IntersectsWith(enemyBlack.Bounds))
                {
                    enemyBlack.Hide();
                    isBlacklive = false;
                }            
            }
            //destroying enemyblue
            for (int i = 0; i < fires.Count; i++)
            {
                if (fires[i].Bounds.IntersectsWith(enemyBlue.Bounds))
                {
                    enemyBlue.Hide();
                    isBlueLive = false;
                }
            }
            //add scoring functionality
            foreach (PictureBox bullet in fires)
            {
                bool removebullet = false;
                foreach(PictureBox pbmeteor in meteorlist)
                {
                    if(pbmeteor.Bounds.IntersectsWith(bullet.Bounds))
                    {
                        score = score + 5;
                        lblscore.Text = "score:" + score.ToString();
                        pbmeteor.Top = this.Height + 2000;
                        pbmeteor.Hide();
                        removebullet = true;
                    }
                }
                if(bullet.Bounds.IntersectsWith(enemyBlack.Bounds))
                {
                    enemyBlack.Hide();
                    isBlacklive = false;
                    removebullet = true;
                }
            }
        }
        
        private void movemeteor(PictureBox meteor)
        {
            meteor.Top += 7;
        }
        private PictureBox createEnemy(Image img)
        {
            PictureBox pbEnemy = new PictureBox();
            int left = rand.Next(30, this.Width);
            int top = rand.Next(5, img.Height + 20);
            pbEnemy.Left = left;
            pbEnemy.Top = top;
            pbEnemy.Image = img;
            pbEnemy.Width = img.Width;
            pbEnemy.Height = img.Height;
            pbEnemy.BackgroundImageLayout = ImageLayout.Stretch;
            pbEnemy.BackColor = Color.Transparent;
            pbEnemy.BackColor = Color.Transparent;
            return pbEnemy;
        }
        private PictureBox createMeteor(Image Meteorimg, PictureBox metoroidbox)
        {
            PictureBox pbmeteor = new PictureBox();
            int left = rand.Next(30, this.Width);
            int top = rand.Next(5, Meteorimg.Height + 20);
            pbmeteor.Left = left;
            pbmeteor.Top = top;
            pbmeteor.Image = Meteorimg;
            pbmeteor.Width = Meteorimg.Width;
            pbmeteor.Height = Meteorimg.Height;
            pbmeteor.BackgroundImageLayout = ImageLayout.Stretch;
            pbmeteor.BackColor = Color.Transparent;
            return pbmeteor;
        }
        private void moveEnemy(PictureBox enemy,ref string enemyDirection)
        {
            if(enemyDirection=="MovingRight")
            {
                enemy.Left = enemy.Left + 10;
            }
            if (enemyDirection == "MovingLeft")
            {
                enemy.Left = enemy.Left - 10;
            }
            if ((enemy.Left+enemy.Width)>this.Width)
            {

                enemyDirection = "MovingLeft";
            }
            if(enemy.Left<=2)
            {
                enemyDirection = "MovingRight";
            }
        }
        private PictureBox createFire(Image fireimg,PictureBox Firebox)
        {
            PictureBox pbFire = new PictureBox();
            pbFire.Image = fireimg;
            pbFire.Width = fireimg.Width;
            pbFire.Height = fireimg.Height;
            pbFire.BackColor = Color.Transparent;
            System.Drawing.Point fireLocation = new System.Drawing.Point();
            fireLocation.X = Firebox.Left + (Firebox.Width / 2) - 10;
            fireLocation.Y = Firebox.Top;
            pbFire.Location = fireLocation;
            return pbFire;
        }
    }
}
