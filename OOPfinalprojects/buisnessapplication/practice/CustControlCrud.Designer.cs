namespace practice
{
    partial class CustControlCrud
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtQuantityCart = new TextBox();
            txtPriceCart = new TextBox();
            txtNameCart = new TextBox();
            lblQuantity = new Label();
            lblPriceCart = new Label();
            lblNameCart = new Label();
            dataGridViewCart = new DataGridView();
            label1 = new Label();
            btnDelCart = new Button();
            btnUpdateCart = new Button();
            btnAddCart = new Button();
            dataGridViewMelist = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMelist).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtQuantityCart);
            panel1.Controls.Add(txtPriceCart);
            panel1.Controls.Add(txtNameCart);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(lblPriceCart);
            panel1.Controls.Add(lblNameCart);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 757);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.enterdatalogo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 80);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 165);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtQuantityCart
            // 
            txtQuantityCart.BackColor = Color.White;
            txtQuantityCart.ForeColor = Color.MidnightBlue;
            txtQuantityCart.Location = new Point(13, 509);
            txtQuantityCart.Name = "txtQuantityCart";
            txtQuantityCart.Size = new Size(155, 31);
            txtQuantityCart.TabIndex = 5;
            // 
            // txtPriceCart
            // 
            txtPriceCart.BackColor = Color.White;
            txtPriceCart.ForeColor = Color.MidnightBlue;
            txtPriceCart.Location = new Point(13, 418);
            txtPriceCart.Name = "txtPriceCart";
            txtPriceCart.Size = new Size(155, 31);
            txtPriceCart.TabIndex = 4;
            // 
            // txtNameCart
            // 
            txtNameCart.BackColor = Color.White;
            txtNameCart.ForeColor = Color.MidnightBlue;
            txtNameCart.Location = new Point(13, 328);
            txtNameCart.Name = "txtNameCart";
            txtNameCart.Size = new Size(155, 31);
            txtNameCart.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuantity.Location = new Point(13, 478);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(95, 27);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // lblPriceCart
            // 
            lblPriceCart.AutoSize = true;
            lblPriceCart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPriceCart.Location = new Point(13, 387);
            lblPriceCart.Name = "lblPriceCart";
            lblPriceCart.Size = new Size(153, 27);
            lblPriceCart.TabIndex = 1;
            lblPriceCart.Text = "Medicine Price";
            // 
            // lblNameCart
            // 
            lblNameCart.AutoSize = true;
            lblNameCart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameCart.Location = new Point(13, 298);
            lblNameCart.Name = "lblNameCart";
            lblNameCart.Size = new Size(163, 27);
            lblNameCart.TabIndex = 0;
            lblNameCart.Text = "Medicine Name";
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.BackgroundColor = Color.MidnightBlue;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.GridColor = SystemColors.ActiveCaption;
            dataGridViewCart.Location = new Point(601, 130);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.ReadOnly = true;
            dataGridViewCart.RowHeadersWidth = 62;
            dataGridViewCart.RowTemplate.Height = 33;
            dataGridViewCart.Size = new Size(394, 416);
            dataGridViewCart.TabIndex = 10;
            dataGridViewCart.CellEnter += dataGridViewCart_CellEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(601, 54);
            label1.Name = "label1";
            label1.Size = new Size(369, 52);
            label1.TabIndex = 11;
            label1.Text = "Customer Cart";
            // 
            // btnDelCart
            // 
            btnDelCart.BackColor = Color.MidnightBlue;
            btnDelCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelCart.ForeColor = SystemColors.ButtonHighlight;
            btnDelCart.Location = new Point(662, 583);
            btnDelCart.Name = "btnDelCart";
            btnDelCart.Size = new Size(129, 59);
            btnDelCart.TabIndex = 15;
            btnDelCart.Text = "Delete";
            btnDelCart.UseVisualStyleBackColor = false;
            btnDelCart.Click += btnDelCart_Click;
            // 
            // btnUpdateCart
            // 
            btnUpdateCart.BackColor = Color.MidnightBlue;
            btnUpdateCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateCart.ForeColor = SystemColors.ButtonHighlight;
            btnUpdateCart.Location = new Point(528, 583);
            btnUpdateCart.Name = "btnUpdateCart";
            btnUpdateCart.Size = new Size(129, 59);
            btnUpdateCart.TabIndex = 14;
            btnUpdateCart.Text = "Update";
            btnUpdateCart.UseVisualStyleBackColor = false;
            btnUpdateCart.Click += btnUpdateCart_Click;
            // 
            // btnAddCart
            // 
            btnAddCart.BackColor = Color.MidnightBlue;
            btnAddCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCart.ForeColor = SystemColors.ButtonHighlight;
            btnAddCart.Location = new Point(394, 583);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(129, 59);
            btnAddCart.TabIndex = 13;
            btnAddCart.Text = "Add";
            btnAddCart.UseVisualStyleBackColor = false;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // dataGridViewMelist
            // 
            dataGridViewMelist.BackgroundColor = Color.MidnightBlue;
            dataGridViewMelist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMelist.GridColor = SystemColors.ActiveCaption;
            dataGridViewMelist.Location = new Point(184, 130);
            dataGridViewMelist.Name = "dataGridViewMelist";
            dataGridViewMelist.ReadOnly = true;
            dataGridViewMelist.RowHeadersWidth = 62;
            dataGridViewMelist.RowTemplate.Height = 33;
            dataGridViewMelist.Size = new Size(394, 416);
            dataGridViewMelist.TabIndex = 16;
            dataGridViewMelist.CellClick += dataGridViewCart_CellEnter;
            dataGridViewMelist.CellContentClick += dataGridViewMelist_CellContentClick;
            dataGridViewMelist.CellEnter += dataGridViewMelist_CellEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(200, 54);
            label2.Name = "label2";
            label2.Size = new Size(354, 52);
            label2.TabIndex = 17;
            label2.Text = "Medicines List";
            // 
            // CustControlCrud
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(label2);
            Controls.Add(dataGridViewMelist);
            Controls.Add(btnDelCart);
            Controls.Add(btnUpdateCart);
            Controls.Add(btnAddCart);
            Controls.Add(label1);
            Controls.Add(dataGridViewCart);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustControlCrud";
            Size = new Size(1020, 757);
            Load += CustControlCrud_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMelist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtQuantityCart;
        private TextBox txtPriceCart;
        private TextBox txtNameCart;
        private Label lblQuantity;
        private Label lblPriceCart;
        private Label lblNameCart;
        private DataGridView dataGridViewCart;
        private Label label1;
        private Button btnDelCart;
        private Button btnUpdateCart;
        private Button btnAddCart;
        private DataGridView dataGridViewMelist;
        private Label label2;
    }
}
