namespace practice
{
    partial class BillWithDiscount
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
            dataGridViewbillcart = new DataGridView();
            lblbill = new Label();
            lbldiscount = new Label();
            lblOrignalBill = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewbillcart).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(489, 81);
            label1.Name = "label1";
            label1.Size = new Size(369, 52);
            label1.TabIndex = 12;
            label1.Text = "Customer Cart";
            // 
            // dataGridViewbillcart
            // 
            dataGridViewbillcart.BackgroundColor = Color.MidnightBlue;
            dataGridViewbillcart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewbillcart.GridColor = SystemColors.ActiveCaption;
            dataGridViewbillcart.Location = new Point(456, 136);
            dataGridViewbillcart.Name = "dataGridViewbillcart";
            dataGridViewbillcart.ReadOnly = true;
            dataGridViewbillcart.RowHeadersWidth = 62;
            dataGridViewbillcart.RowTemplate.Height = 33;
            dataGridViewbillcart.Size = new Size(455, 416);
            dataGridViewbillcart.TabIndex = 13;
            // 
            // lblbill
            // 
            lblbill.AutoSize = true;
            lblbill.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblbill.ForeColor = Color.MidnightBlue;
            lblbill.Location = new Point(15, 165);
            lblbill.Margin = new Padding(4, 0, 4, 0);
            lblbill.Name = "lblbill";
            lblbill.Size = new Size(122, 29);
            lblbill.TabIndex = 14;
            lblbill.Text = "Final Bill";
            // 
            // lbldiscount
            // 
            lbldiscount.AutoSize = true;
            lbldiscount.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lbldiscount.ForeColor = Color.MidnightBlue;
            lbldiscount.Location = new Point(16, 287);
            lbldiscount.Margin = new Padding(4, 0, 4, 0);
            lbldiscount.Name = "lbldiscount";
            lbldiscount.Size = new Size(121, 29);
            lbldiscount.TabIndex = 15;
            lbldiscount.Text = "Discount";
            // 
            // lblOrignalBill
            // 
            lblOrignalBill.AutoSize = true;
            lblOrignalBill.Font = new Font("Gill Sans Ultra Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            lblOrignalBill.ForeColor = Color.MidnightBlue;
            lblOrignalBill.Location = new Point(15, 45);
            lblOrignalBill.Margin = new Padding(4, 0, 4, 0);
            lblOrignalBill.Name = "lblOrignalBill";
            lblOrignalBill.Size = new Size(153, 29);
            lblOrignalBill.TabIndex = 16;
            lblOrignalBill.Text = "Orignal Bill";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblbill);
            panel1.Controls.Add(lblOrignalBill);
            panel1.Controls.Add(lbldiscount);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 668);
            panel1.TabIndex = 17;
            // 
            // BillWithDiscount
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(panel1);
            Controls.Add(dataGridViewbillcart);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "BillWithDiscount";
            Size = new Size(1020, 757);
            Load += BillWithDiscount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewbillcart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewbillcart;
        private Label lblbill;
        private Label lbldiscount;
        private Label lblOrignalBill;
        private Panel panel1;
    }
}
