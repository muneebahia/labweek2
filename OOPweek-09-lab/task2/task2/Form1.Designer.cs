
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
            this.chekSignIn = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnCheckNext = new System.Windows.Forms.Button();
            this.lblHeading1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chekSignIn
            // 
            this.chekSignIn.AutoSize = true;
            this.chekSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekSignIn.Location = new System.Drawing.Point(247, 185);
            this.chekSignIn.Name = "chekSignIn";
            this.chekSignIn.Size = new System.Drawing.Size(94, 29);
            this.chekSignIn.TabIndex = 0;
            this.chekSignIn.Text = "SignIn";
            this.chekSignIn.UseVisualStyleBackColor = true;
            this.chekSignIn.CheckedChanged += new System.EventHandler(this.chekSignIn_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(453, 185);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 29);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "SignUp";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnCheckNext
            // 
            this.btnCheckNext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCheckNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckNext.Location = new System.Drawing.Point(651, 361);
            this.btnCheckNext.Name = "btnCheckNext";
            this.btnCheckNext.Size = new System.Drawing.Size(111, 46);
            this.btnCheckNext.TabIndex = 3;
            this.btnCheckNext.Text = "Next";
            this.btnCheckNext.UseVisualStyleBackColor = false;
            this.btnCheckNext.Click += new System.EventHandler(this.btnCheckNext_Click);
            // 
            // lblHeading1
            // 
            this.lblHeading1.AutoSize = true;
            this.lblHeading1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading1.Location = new System.Drawing.Point(202, 40);
            this.lblHeading1.Name = "lblHeading1";
            this.lblHeading1.Size = new System.Drawing.Size(400, 44);
            this.lblHeading1.TabIndex = 4;
            this.lblHeading1.Text = "SignIn SignUp Application";
            this.lblHeading1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.lblHeading1);
            this.Controls.Add(this.btnCheckNext);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chekSignIn);
            this.Name = "Form1";
            this.Text = "SignInSignUpApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chekSignIn;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnCheckNext;
        private System.Windows.Forms.Label lblHeading1;
    }
}

