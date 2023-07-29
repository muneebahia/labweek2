namespace practice
{
    partial class AdminControlRead
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
            dataGridViewmenu = new DataGridView();
            label1 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDel = new Button();
            lblName = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewmenu
            // 
            dataGridViewmenu.BackgroundColor = Color.MidnightBlue;
            dataGridViewmenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewmenu.GridColor = SystemColors.ActiveCaption;
            dataGridViewmenu.Location = new Point(434, 109);
            dataGridViewmenu.Name = "dataGridViewmenu";
            dataGridViewmenu.ReadOnly = true;
            dataGridViewmenu.RowHeadersWidth = 62;
            dataGridViewmenu.RowTemplate.Height = 33;
            dataGridViewmenu.Size = new Size(516, 416);
            dataGridViewmenu.TabIndex = 1;
            dataGridViewmenu.CellContentClick += dataGridViewmenu_CellContentClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(496, 26);
            label1.Name = "label1";
            label1.Size = new Size(354, 52);
            label1.TabIndex = 3;
            label1.Text = "Medicines List";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MidnightBlue;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(494, 571);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 59);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MidnightBlue;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.ButtonHighlight;
            btnUpdate.Location = new Point(629, 571);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 59);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.MidnightBlue;
            btnDel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.ForeColor = SystemColors.ButtonHighlight;
            btnDel.Location = new Point(763, 571);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(129, 59);
            btnDel.TabIndex = 6;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(73, 298);
            lblName.Name = "lblName";
            lblName.Size = new Size(163, 27);
            lblName.TabIndex = 0;
            lblName.Text = "Medicine Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(73, 387);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(153, 27);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Medicine Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblStock.Location = new Point(73, 478);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(158, 27);
            lblStock.TabIndex = 2;
            lblStock.Text = "Medicine Stock";
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.ForeColor = Color.MidnightBlue;
            txtName.Location = new Point(73, 328);
            txtName.Name = "txtName";
            txtName.Size = new Size(195, 31);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.BackColor = Color.White;
            txtPrice.ForeColor = Color.MidnightBlue;
            txtPrice.Location = new Point(73, 418);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(195, 31);
            txtPrice.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.White;
            txtStock.ForeColor = Color.MidnightBlue;
            txtStock.Location = new Point(73, 509);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(195, 31);
            txtStock.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.enterdatalogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(73, 70);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(197, 165);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(lblName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 757);
            panel1.TabIndex = 8;
            // 
            // AdminControlRead
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(panel1);
            Controls.Add(btnDel);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(dataGridViewmenu);
            DoubleBuffered = true;
            MinimumSize = new Size(750, 645);
            Name = "AdminControlRead";
            Size = new Size(1020, 757);
            Load += AdminControlRead_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewmenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridView dataGridViewmenu;
        private Button btnCreate;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDel;
        private Label lblName;
        private Label lblPrice;
        private Label lblStock;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtStock;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
