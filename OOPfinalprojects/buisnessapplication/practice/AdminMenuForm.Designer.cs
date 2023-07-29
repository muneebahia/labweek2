namespace practice
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            panel1 = new Panel();
            btnbacksignin = new Button();
            button1 = new Button();
            btnGivediscount = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLogOut = new Button();
            btnSort = new Button();
            btnHighestPriceItem = new Button();
            btnFeedback = new Button();
            btnAddCust = new Button();
            btnRead = new Button();
            panelAdmin = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnbacksignin);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnGivediscount);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(btnSort);
            panel1.Controls.Add(btnHighestPriceItem);
            panel1.Controls.Add(btnFeedback);
            panel1.Controls.Add(btnAddCust);
            panel1.Controls.Add(btnRead);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 734);
            panel1.TabIndex = 0;
            // 
            // btnbacksignin
            // 
            btnbacksignin.BackColor = Color.Cyan;
            btnbacksignin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnbacksignin.ForeColor = Color.MidnightBlue;
            btnbacksignin.Location = new Point(10, 756);
            btnbacksignin.Name = "btnbacksignin";
            btnbacksignin.Size = new Size(334, 58);
            btnbacksignin.TabIndex = 13;
            btnbacksignin.Text = "Back To SignIn";
            btnbacksignin.UseVisualStyleBackColor = false;
            btnbacksignin.Click += btnbacksignin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MidnightBlue;
            button1.Location = new Point(11, 564);
            button1.Name = "button1";
            button1.Size = new Size(334, 58);
            button1.TabIndex = 12;
            button1.Text = "Add Another Admin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnGivediscount
            // 
            btnGivediscount.BackColor = Color.Cyan;
            btnGivediscount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGivediscount.ForeColor = Color.MidnightBlue;
            btnGivediscount.Location = new Point(11, 244);
            btnGivediscount.Name = "btnGivediscount";
            btnGivediscount.Size = new Size(334, 58);
            btnGivediscount.TabIndex = 11;
            btnGivediscount.Text = "Give Discount";
            btnGivediscount.UseVisualStyleBackColor = false;
            btnGivediscount.Click += btnGivediscount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(17, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(324, 38);
            label1.TabIndex = 10;
            label1.Text = "Admin Control Pannal";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(76, 48);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 188);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Cyan;
            btnLogOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.MidnightBlue;
            btnLogOut.Image = Properties.Resources.logouticon_removebg_preview__2_;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(12, 692);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(334, 58);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.Cyan;
            btnSort.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSort.ForeColor = Color.MidnightBlue;
            btnSort.Location = new Point(11, 372);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(334, 58);
            btnSort.TabIndex = 7;
            btnSort.Text = "Sorted Medicine List";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += btnSort_Click;
            // 
            // btnHighestPriceItem
            // 
            btnHighestPriceItem.BackColor = Color.Cyan;
            btnHighestPriceItem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnHighestPriceItem.ForeColor = Color.MidnightBlue;
            btnHighestPriceItem.Location = new Point(10, 436);
            btnHighestPriceItem.Name = "btnHighestPriceItem";
            btnHighestPriceItem.Size = new Size(334, 58);
            btnHighestPriceItem.TabIndex = 6;
            btnHighestPriceItem.Text = "Costly Medicine";
            btnHighestPriceItem.UseVisualStyleBackColor = false;
            btnHighestPriceItem.Click += btnHighestPriceItem_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.Cyan;
            btnFeedback.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFeedback.ForeColor = Color.MidnightBlue;
            btnFeedback.Location = new Point(11, 500);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(334, 58);
            btnFeedback.TabIndex = 5;
            btnFeedback.Text = "View Feedbacks";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnAddCust
            // 
            btnAddCust.BackColor = Color.Cyan;
            btnAddCust.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCust.ForeColor = Color.MidnightBlue;
            btnAddCust.Location = new Point(10, 628);
            btnAddCust.Name = "btnAddCust";
            btnAddCust.Size = new Size(334, 58);
            btnAddCust.TabIndex = 4;
            btnAddCust.Text = "Show User";
            btnAddCust.UseVisualStyleBackColor = false;
            btnAddCust.Click += btnAddCust_Click;
            // 
            // btnRead
            // 
            btnRead.BackColor = Color.Cyan;
            btnRead.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRead.ForeColor = Color.MidnightBlue;
            btnRead.Location = new Point(11, 308);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(334, 58);
            btnRead.TabIndex = 0;
            btnRead.Text = "Medicine List";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click_1;
            // 
            // panelAdmin
            // 
            panelAdmin.BackgroundImage = (Image)resources.GetObject("panelAdmin.BackgroundImage");
            panelAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            panelAdmin.Dock = DockStyle.Fill;
            panelAdmin.Location = new Point(349, 0);
            panelAdmin.Margin = new Padding(0);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(1106, 734);
            panelAdmin.TabIndex = 1;
            // 
            // AdminMenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 734);
            Controls.Add(panelAdmin);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MinimumSize = new Size(1122, 690);
            Name = "AdminMenuForm";
            Text = "AdminMenuForm";
            Load += AdminMenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSort;
        private Button btnHighestPriceItem;
        private Button btnFeedback;
        private Button btnAddCust;
        private Button btnRead;
        private Button btnLogOut;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelAdmin;
        private Button btnGivediscount;
        private Button button1;
        private Button btnbacksignin;
    }
}