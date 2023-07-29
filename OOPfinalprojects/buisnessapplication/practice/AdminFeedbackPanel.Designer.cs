namespace practice
{
    partial class AdminFeedbackPanel
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
            dataGridViewadfeedback = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewadfeedback).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewadfeedback
            // 
            dataGridViewadfeedback.BackgroundColor = Color.MidnightBlue;
            dataGridViewadfeedback.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewadfeedback.GridColor = SystemColors.ActiveCaption;
            dataGridViewadfeedback.Location = new Point(254, 182);
            dataGridViewadfeedback.Name = "dataGridViewadfeedback";
            dataGridViewadfeedback.ReadOnly = true;
            dataGridViewadfeedback.RowHeadersWidth = 62;
            dataGridViewadfeedback.RowTemplate.Height = 33;
            dataGridViewadfeedback.Size = new Size(500, 450);
            dataGridViewadfeedback.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 22F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(269, 74);
            label2.Name = "label2";
            label2.Size = new Size(474, 52);
            label2.TabIndex = 12;
            label2.Text = "Cstomers FeedBack";
            // 
            // AdminFeedbackPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(label2);
            Controls.Add(dataGridViewadfeedback);
            DoubleBuffered = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminFeedbackPanel";
            Size = new Size(1020, 757);
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewadfeedback).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewadfeedback;
        private Label label2;
    }
}
