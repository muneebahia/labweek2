
namespace PacManGUI
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
            this.gameLoop = new System.Windows.Forms.Timer(this.components);
            this.lblplayerlive = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameLoop
            // 
            this.gameLoop.Enabled = true;
            this.gameLoop.Interval = 50;
            this.gameLoop.Tick += new System.EventHandler(this.gameLoop_Tick);
            // 
            // lblplayerlive
            // 
            this.lblplayerlive.AutoSize = true;
            this.lblplayerlive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblplayerlive.Location = new System.Drawing.Point(1125, 22);
            this.lblplayerlive.Name = "lblplayerlive";
            this.lblplayerlive.Size = new System.Drawing.Size(45, 20);
            this.lblplayerlive.TabIndex = 0;
            this.lblplayerlive.Text = "Lives";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblscore.Location = new System.Drawing.Point(1129, 71);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(51, 20);
            this.lblscore.TabIndex = 1;
            this.lblscore.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1732, 955);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblplayerlive);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameLoop;
        private System.Windows.Forms.Label lblplayerlive;
        private System.Windows.Forms.Label lblscore;
    }
}

