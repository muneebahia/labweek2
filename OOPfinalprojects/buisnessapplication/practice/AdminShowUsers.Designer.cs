namespace practice
{
    partial class AdminShowUsers
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
            dataGridViewadminshowusers = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewadminshowusers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewadminshowusers
            // 
            dataGridViewadminshowusers.AllowUserToAddRows = false;
            dataGridViewadminshowusers.BackgroundColor = Color.MidnightBlue;
            dataGridViewadminshowusers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewadminshowusers.GridColor = SystemColors.ActiveCaption;
            dataGridViewadminshowusers.Location = new Point(260, 153);
            dataGridViewadminshowusers.Name = "dataGridViewadminshowusers";
            dataGridViewadminshowusers.ReadOnly = true;
            dataGridViewadminshowusers.RowHeadersWidth = 62;
            dataGridViewadminshowusers.RowTemplate.Height = 33;
            dataGridViewadminshowusers.Size = new Size(500, 450);
            dataGridViewadminshowusers.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(270, 65);
            label2.Name = "label2";
            label2.Size = new Size(447, 52);
            label2.TabIndex = 14;
            label2.Text = "Application Users";
            // 
            // AdminShowUsers
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(label2);
            Controls.Add(dataGridViewadminshowusers);
            DoubleBuffered = true;
            Name = "AdminShowUsers";
            Size = new Size(1020, 757);
            Load += AdminShowUsers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewadminshowusers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewadminshowusers;
        private Label label2;
    }
}
