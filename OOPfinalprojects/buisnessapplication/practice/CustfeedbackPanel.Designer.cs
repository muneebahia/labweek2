namespace practice
{
    partial class CustfeedbackPanel
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
            txtbestmed = new TextBox();
            txtfeedback = new TextBox();
            btnaddfeedback = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            colorDialog1 = new ColorDialog();
            label4 = new Label();
            txtUsername = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(391, 430);
            label1.Name = "label1";
            label1.Size = new Size(185, 29);
            label1.TabIndex = 0;
            label1.Text = "Best Medicine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(391, 505);
            label2.Name = "label2";
            label2.Size = new Size(205, 29);
            label2.TabIndex = 1;
            label2.Text = "Enter Feedback";
            // 
            // txtbestmed
            // 
            txtbestmed.Location = new Point(391, 462);
            txtbestmed.Name = "txtbestmed";
            txtbestmed.Size = new Size(268, 31);
            txtbestmed.TabIndex = 2;
            // 
            // txtfeedback
            // 
            txtfeedback.Location = new Point(391, 537);
            txtfeedback.Name = "txtfeedback";
            txtfeedback.Size = new Size(275, 31);
            txtfeedback.TabIndex = 3;
            // 
            // btnaddfeedback
            // 
            btnaddfeedback.BackColor = Color.MidnightBlue;
            btnaddfeedback.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnaddfeedback.ForeColor = SystemColors.ButtonHighlight;
            btnaddfeedback.Location = new Point(736, 604);
            btnaddfeedback.Name = "btnaddfeedback";
            btnaddfeedback.Size = new Size(112, 48);
            btnaddfeedback.TabIndex = 4;
            btnaddfeedback.Text = "Add";
            btnaddfeedback.UseVisualStyleBackColor = false;
            btnaddfeedback.Click += btnaddfeedback_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans Ultra Bold", 14F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(322, 94);
            label3.Name = "label3";
            label3.Size = new Size(382, 42);
            label3.TabIndex = 5;
            label3.Text = "Enter Your Feedback";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(441, 161);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 158);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans Ultra Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MidnightBlue;
            label4.Location = new Point(391, 364);
            label4.Name = "label4";
            label4.Size = new Size(139, 29);
            label4.TabIndex = 12;
            label4.Text = "UserName";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(391, 396);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(268, 31);
            txtUsername.TabIndex = 13;
            // 
            // CustfeedbackPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(txtUsername);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnaddfeedback);
            Controls.Add(txtfeedback);
            Controls.Add(txtbestmed);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "CustfeedbackPanel";
            Size = new Size(1027, 757);
            Load += CustfeedbackPanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtbestmed;
        private TextBox txtfeedback;
        private Button btnaddfeedback;
        private Label label3;
        private PictureBox pictureBox1;
        private ColorDialog colorDialog1;
        private Label label4;
        private TextBox txtUsername;
    }
}
