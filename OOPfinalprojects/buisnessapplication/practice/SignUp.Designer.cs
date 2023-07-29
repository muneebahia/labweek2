namespace practice
{
    partial class SignUp
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
            txtPassword = new TextBox();
            txtName = new TextBox();
            lblNameSignUp = new Label();
            lblPasswordSignUp = new Label();
            btnBackSignUp = new Button();
            btnNextSignUp = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnopeneye = new Button();
            btncloseeye = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(679, 493);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 31);
            txtPassword.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(679, 408);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 31);
            txtName.TabIndex = 2;
            // 
            // lblNameSignUp
            // 
            lblNameSignUp.AutoSize = true;
            lblNameSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameSignUp.ForeColor = Color.MidnightBlue;
            lblNameSignUp.Location = new Point(679, 381);
            lblNameSignUp.Name = "lblNameSignUp";
            lblNameSignUp.Size = new Size(125, 27);
            lblNameSignUp.TabIndex = 4;
            lblNameSignUp.Text = "Enter Name";
            // 
            // lblPasswordSignUp
            // 
            lblPasswordSignUp.AutoSize = true;
            lblPasswordSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordSignUp.ForeColor = Color.MidnightBlue;
            lblPasswordSignUp.Location = new Point(679, 466);
            lblPasswordSignUp.Name = "lblPasswordSignUp";
            lblPasswordSignUp.Size = new Size(158, 27);
            lblPasswordSignUp.TabIndex = 5;
            lblPasswordSignUp.Text = "Enter Password";
            // 
            // btnBackSignUp
            // 
            btnBackSignUp.BackColor = Color.MidnightBlue;
            btnBackSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBackSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnBackSignUp.Location = new Point(673, 580);
            btnBackSignUp.Name = "btnBackSignUp";
            btnBackSignUp.Size = new Size(131, 56);
            btnBackSignUp.TabIndex = 7;
            btnBackSignUp.Text = "Back";
            btnBackSignUp.UseVisualStyleBackColor = false;
            btnBackSignUp.Click += btnBackSignUp_Click;
            // 
            // btnNextSignUp
            // 
            btnNextSignUp.BackColor = Color.MidnightBlue;
            btnNextSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNextSignUp.ForeColor = SystemColors.ButtonHighlight;
            btnNextSignUp.Location = new Point(825, 580);
            btnNextSignUp.Name = "btnNextSignUp";
            btnNextSignUp.Size = new Size(137, 56);
            btnNextSignUp.TabIndex = 8;
            btnNextSignUp.Text = "SignUp";
            btnNextSignUp.UseVisualStyleBackColor = false;
            btnNextSignUp.Click += btnNextSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(741, 84);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 29);
            label1.TabIndex = 10;
            label1.Text = "Sign Up Page";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(741, 178);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 158);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnopeneye
            // 
            btnopeneye.BackgroundImage = Properties.Resources.openeye;
            btnopeneye.BackgroundImageLayout = ImageLayout.Stretch;
            btnopeneye.Location = new Point(908, 493);
            btnopeneye.Name = "btnopeneye";
            btnopeneye.Size = new Size(54, 31);
            btnopeneye.TabIndex = 11;
            btnopeneye.UseVisualStyleBackColor = true;
            btnopeneye.Click += btnopeneye_Click;
            // 
            // btncloseeye
            // 
            btncloseeye.BackgroundImage = Properties.Resources.closeeye;
            btncloseeye.BackgroundImageLayout = ImageLayout.Stretch;
            btncloseeye.Location = new Point(908, 493);
            btncloseeye.Name = "btncloseeye";
            btncloseeye.Size = new Size(54, 31);
            btncloseeye.TabIndex = 12;
            btncloseeye.UseVisualStyleBackColor = true;
            btncloseeye.Click += btncloseeye_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1455, 734);
            Controls.Add(btncloseeye);
            Controls.Add(btnopeneye);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnNextSignUp);
            Controls.Add(btnBackSignUp);
            Controls.Add(lblPasswordSignUp);
            Controls.Add(lblNameSignUp);
            Controls.Add(txtName);
            Controls.Add(txtPassword);
            DoubleBuffered = true;
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label lblNameSignUp;
        private Label lblPasswordSignUp;
        private Button btnBackSignUp;
        private Button btnNextSignUp;
        private TextBox textBox3;
        private Label lblEmail;
        private TextBox txtPassword;
        private TextBox txtName;
        private TextBox txtEmail;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnopeneye;
        private Button btncloseeye;
    }
}