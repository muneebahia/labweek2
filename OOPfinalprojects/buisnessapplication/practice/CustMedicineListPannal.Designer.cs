namespace practice
{
    partial class CustMedicineListPannal
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
            dataGridViewmenuCust = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewmenuCust).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewmenuCust
            // 
            dataGridViewmenuCust.BackgroundColor = Color.MidnightBlue;
            dataGridViewmenuCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewmenuCust.GridColor = SystemColors.ActiveCaption;
            dataGridViewmenuCust.Location = new Point(256, 170);
            dataGridViewmenuCust.Name = "dataGridViewmenuCust";
            dataGridViewmenuCust.ReadOnly = true;
            dataGridViewmenuCust.RowHeadersWidth = 62;
            dataGridViewmenuCust.RowTemplate.Height = 33;
            dataGridViewmenuCust.Size = new Size(516, 416);
            dataGridViewmenuCust.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(317, 59);
            label1.Name = "label1";
            label1.Size = new Size(354, 52);
            label1.TabIndex = 4;
            label1.Text = "Medicines List";
            // 
            // CustMedicineListPannal
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(label1);
            Controls.Add(dataGridViewmenuCust);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustMedicineListPannal";
            Size = new Size(1027, 757);
            Load += CustMedicineListPannal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewmenuCust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewmenuCust;
        private Label label1;
    }
}
