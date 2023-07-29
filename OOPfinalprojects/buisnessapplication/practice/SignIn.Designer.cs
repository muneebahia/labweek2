namespace practice
{
    partial class SignIn
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
            txtName = new TextBox();
            txtPassword = new TextBox();
            lblName = new Label();
            lblPassword = new Label();
            btnBack = new Button();
            btnNext = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            btncloseeye = new Button();
            btnopeneye = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(736, 385);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 31);
            txtName.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(736, 467);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(283, 31);
            txtPassword.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(736, 355);
            lblName.Name = "lblName";
            lblName.Size = new Size(125, 27);
            lblName.TabIndex = 3;
            lblName.Text = "Enter Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(736, 437);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(158, 27);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Enter Password";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.MidnightBlue;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ButtonHighlight;
            btnBack.Location = new Point(736, 659);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(130, 43);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.MidnightBlue;
            btnNext.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ButtonHighlight;
            btnNext.Location = new Point(898, 659);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(121, 43);
            btnNext.TabIndex = 7;
            btnNext.Text = "SignIn";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(787, 165);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 158);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(803, 121);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 29);
            label1.TabIndex = 11;
            label1.Text = "Login Page";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(794, 539);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(156, 24);
            linkLabel1.TabIndex = 12;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // btncloseeye
            // 
            btncloseeye.BackgroundImage = Properties.Resources.closeeye;
            btncloseeye.BackgroundImageLayout = ImageLayout.Stretch;
            btncloseeye.Location = new Point(965, 467);
            btncloseeye.Name = "btncloseeye";
            btncloseeye.Size = new Size(54, 31);
            btncloseeye.TabIndex = 13;
            btncloseeye.UseVisualStyleBackColor = true;
            btncloseeye.Click += btncloseeye_Click;
            // 
            // btnopeneye
            // 
            btnopeneye.BackgroundImage = Properties.Resources.openeye;
            btnopeneye.BackgroundImageLayout = ImageLayout.Stretch;
            btnopeneye.Location = new Point(965, 467);
            btnopeneye.Name = "btnopeneye";
            btnopeneye.Size = new Size(54, 31);
            btnopeneye.TabIndex = 14;
            btnopeneye.UseVisualStyleBackColor = true;
            btnopeneye.Click += btnopeneye_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1455, 734);
            Controls.Add(btnopeneye);
            Controls.Add(btncloseeye);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            DoubleBuffered = true;
            Name = "SignIn";
            Text = "SignIn";
            Load += SignIn_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtPassword;
        private Label lblName;
        private Label lblPassword;
        private Button btnBack;
        private Button btnNext;
        private PictureBox pictureBox1;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button btncloseeye;
        private Button btnopeneye;
    }
}