namespace practice
{
    partial class CustControlPannal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustControlPannal));
            panel1 = new Panel();
            btnbacksignin = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnLogOut = new Button();
            bthBill = new Button();
            btnDiscount = new Button();
            btnFeedbackCust = new Button();
            btnCustCart = new Button();
            btnList = new Button();
            panelCustomer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnbacksignin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(bthBill);
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(btnFeedbackCust);
            panel1.Controls.Add(btnCustCart);
            panel1.Controls.Add(btnList);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 734);
            panel1.TabIndex = 1;
            // 
            // btnbacksignin
            // 
            btnbacksignin.BackColor = Color.Cyan;
            btnbacksignin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnbacksignin.ForeColor = Color.MidnightBlue;
            btnbacksignin.Location = new Point(10, 693);
            btnbacksignin.Name = "btnbacksignin";
            btnbacksignin.Size = new Size(334, 58);
            btnbacksignin.TabIndex = 14;
            btnbacksignin.Text = "Back To SignIn";
            btnbacksignin.UseVisualStyleBackColor = false;
            btnbacksignin.Click += btnbacksignin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(23, 46);
            label1.Name = "label1";
            label1.Size = new Size(304, 27);
            label1.TabIndex = 10;
            label1.Text = "Customer Control Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(74, 106);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 195);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Cyan;
            btnLogOut.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.MidnightBlue;
            btnLogOut.Location = new Point(10, 629);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(334, 58);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "LogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // bthBill
            // 
            bthBill.BackColor = Color.Cyan;
            bthBill.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bthBill.ForeColor = Color.MidnightBlue;
            bthBill.Location = new Point(10, 565);
            bthBill.Name = "bthBill";
            bthBill.Size = new Size(334, 58);
            bthBill.TabIndex = 7;
            bthBill.Text = "BillWithDiscount";
            bthBill.UseVisualStyleBackColor = false;
            bthBill.Click += bthBill_Click;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = Color.Cyan;
            btnDiscount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiscount.ForeColor = Color.MidnightBlue;
            btnDiscount.Location = new Point(10, 501);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(334, 58);
            btnDiscount.TabIndex = 6;
            btnDiscount.Text = "Discount";
            btnDiscount.UseVisualStyleBackColor = false;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // btnFeedbackCust
            // 
            btnFeedbackCust.BackColor = Color.Cyan;
            btnFeedbackCust.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFeedbackCust.ForeColor = Color.MidnightBlue;
            btnFeedbackCust.Location = new Point(10, 437);
            btnFeedbackCust.Name = "btnFeedbackCust";
            btnFeedbackCust.Size = new Size(334, 58);
            btnFeedbackCust.TabIndex = 5;
            btnFeedbackCust.Text = "Feedbacks";
            btnFeedbackCust.UseVisualStyleBackColor = false;
            btnFeedbackCust.Click += btnFeedbackCust_Click;
            // 
            // btnCustCart
            // 
            btnCustCart.BackColor = Color.Cyan;
            btnCustCart.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustCart.ForeColor = Color.MidnightBlue;
            btnCustCart.Location = new Point(10, 373);
            btnCustCart.Name = "btnCustCart";
            btnCustCart.Size = new Size(334, 58);
            btnCustCart.TabIndex = 4;
            btnCustCart.Text = "Users Cart";
            btnCustCart.UseVisualStyleBackColor = false;
            btnCustCart.Click += btnCustCart_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.Cyan;
            btnList.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnList.ForeColor = Color.MidnightBlue;
            btnList.Location = new Point(10, 309);
            btnList.Name = "btnList";
            btnList.Size = new Size(334, 58);
            btnList.TabIndex = 0;
            btnList.Text = "Medicine List";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnRead_Click;
            // 
            // panelCustomer
            // 
            panelCustomer.BackgroundImage = (Image)resources.GetObject("panelCustomer.BackgroundImage");
            panelCustomer.BackgroundImageLayout = ImageLayout.Stretch;
            panelCustomer.Dock = DockStyle.Fill;
            panelCustomer.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panelCustomer.Location = new Point(349, 0);
            panelCustomer.Margin = new Padding(0);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Size = new Size(1106, 734);
            panelCustomer.TabIndex = 2;
            // 
            // CustControlPannal
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 734);
            Controls.Add(panelCustomer);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustControlPannal";
            Text = "CustControlPannal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLogOut;
        private Button bthBill;
        private Button btnDiscount;
        private Button btnFeedbackCust;
        private Button btnCustCart;
        private Button btnList;
        private Panel panelCustomer;
        private Label label1;
        private Button btnbacksignin;
    }
}