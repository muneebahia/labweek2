namespace practice
{
    partial class LoginForm
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
            lblName = new Label();
            rdbtnSignUp = new RadioButton();
            rdbtnSignIn = new RadioButton();
            btnNext = new Button();
            radioButton1 = new RadioButton();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Gill Sans Ultra Bold", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(463, 149);
            lblName.Name = "lblName";
            lblName.Size = new Size(599, 50);
            lblName.TabIndex = 0;
            lblName.Text = "Welcome to Planet Health";
            // 
            // rdbtnSignUp
            // 
            rdbtnSignUp.Anchor = AnchorStyles.None;
            rdbtnSignUp.AutoSize = true;
            rdbtnSignUp.BackColor = Color.Transparent;
            rdbtnSignUp.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rdbtnSignUp.ForeColor = Color.MidnightBlue;
            rdbtnSignUp.Location = new Point(896, 294);
            rdbtnSignUp.Name = "rdbtnSignUp";
            rdbtnSignUp.Padding = new Padding(3);
            rdbtnSignUp.Size = new Size(152, 43);
            rdbtnSignUp.TabIndex = 1;
            rdbtnSignUp.TabStop = true;
            rdbtnSignUp.Text = "SignUp";
            rdbtnSignUp.UseVisualStyleBackColor = false;
            // 
            // rdbtnSignIn
            // 
            rdbtnSignIn.Anchor = AnchorStyles.None;
            rdbtnSignIn.AutoSize = true;
            rdbtnSignIn.BackColor = Color.Transparent;
            rdbtnSignIn.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rdbtnSignIn.ForeColor = Color.MidnightBlue;
            rdbtnSignIn.Location = new Point(896, 343);
            rdbtnSignIn.Name = "rdbtnSignIn";
            rdbtnSignIn.Size = new Size(139, 37);
            rdbtnSignIn.TabIndex = 2;
            rdbtnSignIn.TabStop = true;
            rdbtnSignIn.Text = "SignIn";
            rdbtnSignIn.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.BackColor = Color.MidnightBlue;
            btnNext.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1234, 622);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(161, 55);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.None;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Stencil", 14F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.MidnightBlue;
            radioButton1.Location = new Point(896, 386);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 37);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Exit";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImage = Properties.Resources.backgroundimg4;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1455, 734);
            Controls.Add(radioButton1);
            Controls.Add(btnNext);
            Controls.Add(rdbtnSignIn);
            Controls.Add(rdbtnSignUp);
            Controls.Add(lblName);
            DoubleBuffered = true;
            ForeColor = Color.PaleTurquoise;
            MinimumSize = new Size(448, 520);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private RadioButton rdbtnSignUp;
        private RadioButton rdbtnSignIn;
        private Button btnNext;
        private RadioButton radioButton1;
    }
}