
namespace week1onGUIspaceshootergame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timergameloop = new System.Windows.Forms.Timer(this.components);
            this.playerHealthbar = new System.Windows.Forms.ProgressBar();
            this.lblscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::week1onGUIspaceshootergame.Properties.Resources.player;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(398, 447);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timergameloop
            // 
            this.timergameloop.Enabled = true;
            this.timergameloop.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playerHealthbar
            // 
            this.playerHealthbar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playerHealthbar.Location = new System.Drawing.Point(398, 597);
            this.playerHealthbar.Name = "playerHealthbar";
            this.playerHealthbar.Size = new System.Drawing.Size(125, 23);
            this.playerHealthbar.TabIndex = 1;
            this.playerHealthbar.Value = 100;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(42, 40);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(51, 20);
            this.lblscore.TabIndex = 2;
            this.lblscore.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::week1onGUIspaceshootergame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 639);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.playerHealthbar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timergameloop;
        private System.Windows.Forms.ProgressBar playerHealthbar;
        private System.Windows.Forms.Label lblscore;
    }
}

