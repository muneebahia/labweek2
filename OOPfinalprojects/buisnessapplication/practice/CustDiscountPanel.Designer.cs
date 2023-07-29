namespace practice
{
    partial class CustDiscountPanel
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
            dataGridViewcustdiscount = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcustdiscount).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewcustdiscount
            // 
            dataGridViewcustdiscount.BackgroundColor = Color.MidnightBlue;
            dataGridViewcustdiscount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewcustdiscount.GridColor = SystemColors.ActiveCaption;
            dataGridViewcustdiscount.Location = new Point(271, 159);
            dataGridViewcustdiscount.Name = "dataGridViewcustdiscount";
            dataGridViewcustdiscount.ReadOnly = true;
            dataGridViewcustdiscount.RowHeadersWidth = 62;
            dataGridViewcustdiscount.RowTemplate.Height = 33;
            dataGridViewcustdiscount.Size = new Size(500, 450);
            dataGridViewcustdiscount.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(271, 70);
            label2.Name = "label2";
            label2.Size = new Size(470, 52);
            label2.TabIndex = 13;
            label2.Text = "Available Discount";
            // 
            // CustDiscountPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(label2);
            Controls.Add(dataGridViewcustdiscount);
            DoubleBuffered = true;
            Name = "CustDiscountPanel";
            Size = new Size(1020, 757);
            Load += CustDiscountPanel_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewcustdiscount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewcustdiscount;
        private Label label2;
    }
}
