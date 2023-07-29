namespace practice
{
    partial class sortedlistpannal
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
            dataGridViewsortedmenu = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsortedmenu).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewsortedmenu
            // 
            dataGridViewsortedmenu.BackgroundColor = Color.MidnightBlue;
            dataGridViewsortedmenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsortedmenu.GridColor = SystemColors.ActiveCaption;
            dataGridViewsortedmenu.Location = new Point(177, 106);
            dataGridViewsortedmenu.Margin = new Padding(2);
            dataGridViewsortedmenu.Name = "dataGridViewsortedmenu";
            dataGridViewsortedmenu.RowHeadersWidth = 62;
            dataGridViewsortedmenu.RowTemplate.Height = 33;
            dataGridViewsortedmenu.Size = new Size(361, 260);
            dataGridViewsortedmenu.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(177, 39);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(346, 35);
            label1.TabIndex = 5;
            label1.Text = "Sorted Medicine List";
            // 
            // sortedlistpannal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(label1);
            Controls.Add(dataGridViewsortedmenu);
            Name = "sortedlistpannal";
            Size = new Size(714, 473);
            Load += sortedlistpannal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewsortedmenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewsortedmenu;
        private Label label1;
    }
}
