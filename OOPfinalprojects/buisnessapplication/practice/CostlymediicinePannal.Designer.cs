namespace practice
{
    partial class CostlymediicinePannal
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
            costlydata = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)costlydata).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(300, 143);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(416, 38);
            label1.TabIndex = 0;
            label1.Text = "Medicine With Highest Price";
            // 
            // costlydata
            // 
            costlydata.BackgroundColor = Color.MidnightBlue;
            costlydata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            costlydata.Location = new Point(252, 236);
            costlydata.Margin = new Padding(4, 5, 4, 5);
            costlydata.Name = "costlydata";
            costlydata.ReadOnly = true;
            costlydata.RowHeadersWidth = 62;
            costlydata.RowTemplate.Height = 25;
            costlydata.Size = new Size(516, 201);
            costlydata.TabIndex = 11;
            // 
            // CostlymediicinePannal
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(costlydata);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "CostlymediicinePannal";
            Size = new Size(1027, 757);
            Load += CostlymediicinePannal_Load;
            ((System.ComponentModel.ISupportInitialize)costlydata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView costlydata;
    }
}
