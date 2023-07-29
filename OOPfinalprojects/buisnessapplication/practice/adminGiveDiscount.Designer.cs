namespace practice
{
    partial class adminGiveDiscount
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
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            txtdiscountprice = new TextBox();
            txtdiscountpercent = new TextBox();
            btnadddiscount = new Button();
            button1 = new Button();
            dataGridViewgivecustdiscount = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewgivecustdiscount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(60, 400);
            label1.Name = "label1";
            label1.Size = new Size(344, 29);
            label1.TabIndex = 1;
            label1.Text = "Enter Discount Percentage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(60, 315);
            label2.Name = "label2";
            label2.Size = new Size(266, 29);
            label2.TabIndex = 2;
            label2.Text = "Enter discount Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(59, 35);
            label3.Name = "label3";
            label3.Size = new Size(500, 42);
            label3.TabIndex = 6;
            label3.Text = "Give Discount To Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(163, 122);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 158);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtdiscountprice
            // 
            txtdiscountprice.Location = new Point(60, 347);
            txtdiscountprice.Name = "txtdiscountprice";
            txtdiscountprice.Size = new Size(344, 31);
            txtdiscountprice.TabIndex = 13;
            // 
            // txtdiscountpercent
            // 
            txtdiscountpercent.Location = new Point(60, 432);
            txtdiscountpercent.Name = "txtdiscountpercent";
            txtdiscountpercent.Size = new Size(344, 31);
            txtdiscountpercent.TabIndex = 14;
            // 
            // btnadddiscount
            // 
            btnadddiscount.BackColor = Color.MidnightBlue;
            btnadddiscount.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnadddiscount.ForeColor = SystemColors.ButtonHighlight;
            btnadddiscount.Location = new Point(561, 420);
            btnadddiscount.Name = "btnadddiscount";
            btnadddiscount.Size = new Size(132, 48);
            btnadddiscount.TabIndex = 15;
            btnadddiscount.Text = "Add";
            btnadddiscount.UseVisualStyleBackColor = false;
            btnadddiscount.Click += btnadddiscount_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MidnightBlue;
            button1.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(807, 420);
            button1.Name = "button1";
            button1.Size = new Size(132, 48);
            button1.TabIndex = 16;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewgivecustdiscount
            // 
            dataGridViewgivecustdiscount.BackgroundColor = Color.MidnightBlue;
            dataGridViewgivecustdiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewgivecustdiscount.GridColor = SystemColors.ActiveCaption;
            dataGridViewgivecustdiscount.Location = new Point(561, 226);
            dataGridViewgivecustdiscount.Name = "dataGridViewgivecustdiscount";
            dataGridViewgivecustdiscount.ReadOnly = true;
            dataGridViewgivecustdiscount.RowHeadersWidth = 62;
            dataGridViewgivecustdiscount.RowTemplate.Height = 33;
            dataGridViewgivecustdiscount.Size = new Size(397, 130);
            dataGridViewgivecustdiscount.TabIndex = 17;
            dataGridViewgivecustdiscount.CellContentClick += dataGridViewgivecustdiscount_CellContentClick;
            // 
            // adminGiveDiscount
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(dataGridViewgivecustdiscount);
            Controls.Add(button1);
            Controls.Add(btnadddiscount);
            Controls.Add(txtdiscountpercent);
            Controls.Add(txtdiscountprice);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "adminGiveDiscount";
            Size = new Size(1020, 757);
            Load += adminGiveDiscount_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewgivecustdiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtdiscountprice;
        private TextBox txtdiscountpercent;
        private Button btnadddiscount;
        private Button button1;
        private DataGridView dataGridViewgivecustdiscount;
    }
}
