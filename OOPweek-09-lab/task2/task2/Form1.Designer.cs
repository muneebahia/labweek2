
namespace task2
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
            this.btnCheckNext = new System.Windows.Forms.Button();
            this.lblHeading1 = new System.Windows.Forms.Label();
            this.radsignin = new System.Windows.Forms.RadioButton();
            this.radsignup = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCheckNext
            // 
            this.btnCheckNext.BackColor = System.Drawing.Color.Navy;
            this.btnCheckNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckNext.Location = new System.Drawing.Point(651, 361);
            this.btnCheckNext.Name = "btnCheckNext";
            this.btnCheckNext.Padding = new System.Windows.Forms.Padding(5);
            this.btnCheckNext.Size = new System.Drawing.Size(111, 46);
            this.btnCheckNext.TabIndex = 3;
            this.btnCheckNext.Text = "Next";
            this.btnCheckNext.UseVisualStyleBackColor = false;
            this.btnCheckNext.Click += new System.EventHandler(this.btnCheckNext_Click);
            // 
            // lblHeading1
            // 
            this.lblHeading1.AutoSize = true;
            this.lblHeading1.Font = new System.Drawing.Font("Showcard Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading1.ForeColor = System.Drawing.Color.Navy;
            this.lblHeading1.Location = new System.Drawing.Point(126, 52);
            this.lblHeading1.Name = "lblHeading1";
            this.lblHeading1.Size = new System.Drawing.Size(531, 44);
            this.lblHeading1.TabIndex = 4;
            this.lblHeading1.Text = "SignIn SignUp Application";
            this.lblHeading1.Visible = false;
            // 
            // radsignin
            // 
            this.radsignin.AutoSize = true;
            this.radsignin.BackColor = System.Drawing.Color.Navy;
            this.radsignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radsignin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radsignin.Location = new System.Drawing.Point(157, 174);
            this.radsignin.Name = "radsignin";
            this.radsignin.Padding = new System.Windows.Forms.Padding(5);
            this.radsignin.Size = new System.Drawing.Size(96, 34);
            this.radsignin.TabIndex = 5;
            this.radsignin.TabStop = true;
            this.radsignin.Text = "SignIn";
            this.radsignin.UseVisualStyleBackColor = false;
            // 
            // radsignup
            // 
            this.radsignup.AutoSize = true;
            this.radsignup.BackColor = System.Drawing.Color.Navy;
            this.radsignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radsignup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radsignup.Location = new System.Drawing.Point(157, 238);
            this.radsignup.Name = "radsignup";
            this.radsignup.Padding = new System.Windows.Forms.Padding(5);
            this.radsignup.Size = new System.Drawing.Size(103, 34);
            this.radsignup.TabIndex = 6;
            this.radsignup.TabStop = true;
            this.radsignup.Text = "SignUp";
            this.radsignup.UseVisualStyleBackColor = false;
            this.radsignup.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.radsignup);
            this.Controls.Add(this.radsignin);
            this.Controls.Add(this.lblHeading1);
            this.Controls.Add(this.btnCheckNext);
            this.Name = "Form1";
            this.Text = "SignInSignUpApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheckNext;
        private System.Windows.Forms.Label lblHeading1;
        private System.Windows.Forms.RadioButton radsignin;
        private System.Windows.Forms.RadioButton radsignup;
    }
}

