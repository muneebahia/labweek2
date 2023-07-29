namespace practice
{
    partial class AddAdmins
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lblNameSignUp = new Label();
            txtAdminName = new TextBox();
            lblPasswordSignUp = new Label();
            txtAdminPassword = new TextBox();
            btnAddAdmin = new Button();
            btnopeneye = new Button();
            btncloseeye = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(387, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(267, 29);
            label1.TabIndex = 11;
            label1.Text = "Add Another Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(447, 178);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 158);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblNameSignUp
            // 
            lblNameSignUp.AutoSize = true;
            lblNameSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameSignUp.ForeColor = Color.MidnightBlue;
            lblNameSignUp.Location = new Point(387, 386);
            lblNameSignUp.Name = "lblNameSignUp";
            lblNameSignUp.Size = new Size(125, 27);
            lblNameSignUp.TabIndex = 13;
            lblNameSignUp.Text = "Enter Name";
            // 
            // txtAdminName
            // 
            txtAdminName.Location = new Point(387, 416);
            txtAdminName.Name = "txtAdminName";
            txtAdminName.Size = new Size(283, 31);
            txtAdminName.TabIndex = 14;
            // 
            // lblPasswordSignUp
            // 
            lblPasswordSignUp.AutoSize = true;
            lblPasswordSignUp.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasswordSignUp.ForeColor = Color.MidnightBlue;
            lblPasswordSignUp.Location = new Point(387, 482);
            lblPasswordSignUp.Name = "lblPasswordSignUp";
            lblPasswordSignUp.Size = new Size(158, 27);
            lblPasswordSignUp.TabIndex = 15;
            lblPasswordSignUp.Text = "Enter Password";
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Location = new Point(387, 512);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.Size = new Size(283, 31);
            txtAdminPassword.TabIndex = 16;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.BackColor = Color.MidnightBlue;
            btnAddAdmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddAdmin.ForeColor = SystemColors.ButtonHighlight;
            btnAddAdmin.Location = new Point(746, 661);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(137, 56);
            btnAddAdmin.TabIndex = 17;
            btnAddAdmin.Text = "Add Admin";
            btnAddAdmin.UseVisualStyleBackColor = false;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // btnopeneye
            // 
            btnopeneye.BackgroundImage = Properties.Resources.openeye;
            btnopeneye.BackgroundImageLayout = ImageLayout.Stretch;
            btnopeneye.Location = new Point(616, 512);
            btnopeneye.Name = "btnopeneye";
            btnopeneye.Size = new Size(54, 31);
            btnopeneye.TabIndex = 18;
            btnopeneye.UseVisualStyleBackColor = true;
            btnopeneye.Click += btnopeneye_Click;
            // 
            // btncloseeye
            // 
            btncloseeye.BackgroundImage = Properties.Resources.closeeye;
            btncloseeye.BackgroundImageLayout = ImageLayout.Stretch;
            btncloseeye.Location = new Point(616, 512);
            btncloseeye.Name = "btncloseeye";
            btncloseeye.Size = new Size(54, 31);
            btncloseeye.TabIndex = 19;
            btncloseeye.UseVisualStyleBackColor = true;
            btncloseeye.Click += btncloseeye_Click;
            // 
            // AddAdmins
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(btncloseeye);
            Controls.Add(btnopeneye);
            Controls.Add(btnAddAdmin);
            Controls.Add(txtAdminPassword);
            Controls.Add(lblPasswordSignUp);
            Controls.Add(txtAdminName);
            Controls.Add(lblNameSignUp);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "AddAdmins";
            Size = new Size(1020, 757);
            Load += AddAdmins_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label lblNameSignUp;
        private TextBox txtAdminName;
        private Label lblPasswordSignUp;
        private TextBox txtAdminPassword;
        private Button btnAddAdmin;
        private Button btnopeneye;
        private Button btncloseeye;
    }
}
