
namespace PacManGUI
{
    partial class Form2
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
            this.btnrestart = new System.Windows.Forms.Button();
            this.btnendgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.SystemColors.Info;
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrestart.Location = new System.Drawing.Point(337, 528);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(146, 44);
            this.btnrestart.TabIndex = 0;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // btnendgame
            // 
            this.btnendgame.BackColor = System.Drawing.SystemColors.Info;
            this.btnendgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnendgame.Location = new System.Drawing.Point(633, 528);
            this.btnendgame.Name = "btnendgame";
            this.btnendgame.Size = new System.Drawing.Size(142, 44);
            this.btnendgame.TabIndex = 1;
            this.btnendgame.Text = "GameEnd";
            this.btnendgame.UseVisualStyleBackColor = false;
            this.btnendgame.Click += new System.EventHandler(this.btnendgame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacManGUI.Properties.Resources.gameover;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 677);
            this.Controls.Add(this.btnendgame);
            this.Controls.Add(this.btnrestart);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "gameover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.Button btnendgame;
    }
}