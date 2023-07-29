namespace practice
{
    partial class changePassword
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnpasswordUpdate = new Button();
            lblPassword = new Label();
            lblName = new Label();
            txtoldPassword = new TextBox();
            txtoldName = new TextBox();
            label2 = new Label();
            txtnewPassword = new TextBox();
            btncloseoldeye = new Button();
            btnopenoldeye = new Button();
            btnopenneweye = new Button();
            btncloseneweye = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(623, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 42);
            label1.TabIndex = 19;
            label1.Text = "Change Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(698, 128);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 158);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnpasswordUpdate
            // 
            btnpasswordUpdate.BackColor = Color.MidnightBlue;
            btnpasswordUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnpasswordUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnpasswordUpdate.Location = new Point(1077, 583);
            btnpasswordUpdate.Name = "btnpasswordUpdate";
            btnpasswordUpdate.Size = new Size(121, 43);
            btnpasswordUpdate.TabIndex = 17;
            btnpasswordUpdate.Text = "Update";
            btnpasswordUpdate.UseVisualStyleBackColor = false;
            btnpasswordUpdate.Click += btnpasswordUpdate_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(638, 401);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(198, 27);
            lblPassword.TabIndex = 16;
            lblPassword.Text = "Enter Old Password";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.MidnightBlue;
            lblName.Location = new Point(638, 319);
            lblName.Name = "lblName";
            lblName.Size = new Size(208, 27);
            lblName.TabIndex = 15;
            lblName.Text = "Enter Old UserName";
            // 
            // txtoldPassword
            // 
            txtoldPassword.Location = new Point(639, 431);
            txtoldPassword.Name = "txtoldPassword";
            txtoldPassword.Size = new Size(283, 31);
            txtoldPassword.TabIndex = 14;
            // 
            // txtoldName
            // 
            txtoldName.Location = new Point(639, 349);
            txtoldName.Name = "txtoldName";
            txtoldName.Size = new Size(283, 31);
            txtoldName.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(638, 479);
            label2.Name = "label2";
            label2.Size = new Size(207, 27);
            label2.TabIndex = 22;
            label2.Text = "Enter New Password";
            // 
            // txtnewPassword
            // 
            txtnewPassword.Location = new Point(639, 509);
            txtnewPassword.Name = "txtnewPassword";
            txtnewPassword.Size = new Size(283, 31);
            txtnewPassword.TabIndex = 21;
            // 
            // btncloseoldeye
            // 
            btncloseoldeye.BackgroundImage = Properties.Resources.closeeye;
            btncloseoldeye.BackgroundImageLayout = ImageLayout.Stretch;
            btncloseoldeye.Location = new Point(868, 431);
            btncloseoldeye.Name = "btncloseoldeye";
            btncloseoldeye.Size = new Size(54, 31);
            btncloseoldeye.TabIndex = 23;
            btncloseoldeye.UseVisualStyleBackColor = true;
            btncloseoldeye.Click += btncloseoldeye_Click;
            // 
            // btnopenoldeye
            // 
            btnopenoldeye.BackgroundImage = Properties.Resources.openeye;
            btnopenoldeye.BackgroundImageLayout = ImageLayout.Stretch;
            btnopenoldeye.Location = new Point(868, 431);
            btnopenoldeye.Name = "btnopenoldeye";
            btnopenoldeye.Size = new Size(54, 31);
            btnopenoldeye.TabIndex = 24;
            btnopenoldeye.UseVisualStyleBackColor = true;
            btnopenoldeye.Click += btnopenoldeye_Click;
            // 
            // btnopenneweye
            // 
            btnopenneweye.BackgroundImage = Properties.Resources.openeye;
            btnopenneweye.BackgroundImageLayout = ImageLayout.Stretch;
            btnopenneweye.Location = new Point(868, 509);
            btnopenneweye.Name = "btnopenneweye";
            btnopenneweye.Size = new Size(54, 31);
            btnopenneweye.TabIndex = 25;
            btnopenneweye.UseVisualStyleBackColor = true;
            btnopenneweye.Click += btnopenneweye_Click;
            // 
            // btncloseneweye
            // 
            btncloseneweye.BackgroundImage = Properties.Resources.closeeye;
            btncloseneweye.BackgroundImageLayout = ImageLayout.Stretch;
            btncloseneweye.Location = new Point(868, 509);
            btncloseneweye.Name = "btncloseneweye";
            btncloseneweye.Size = new Size(54, 31);
            btncloseneweye.TabIndex = 26;
            btncloseneweye.UseVisualStyleBackColor = true;
            btncloseneweye.Click += btncloseneweye_Click;
            // 
            // changePassword
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1455, 734);
            Controls.Add(btncloseneweye);
            Controls.Add(btnopenneweye);
            Controls.Add(btnopenoldeye);
            Controls.Add(btncloseoldeye);
            Controls.Add(label2);
            Controls.Add(txtnewPassword);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnpasswordUpdate);
            Controls.Add(lblPassword);
            Controls.Add(lblName);
            Controls.Add(txtoldPassword);
            Controls.Add(txtoldName);
            Name = "changePassword";
            Text = "changePassword";
            Load += changePassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnpasswordUpdate;
        private Label lblPassword;
        private Label lblName;
        private TextBox txtoldPassword;
        private TextBox txtoldName;
        private Label label2;
        private TextBox txtnewPassword;
        private Button btncloseoldeye;
        private Button btnopenoldeye;
        private Button btnopenneweye;
        private Button btncloseneweye;
    }
}