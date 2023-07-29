using practice.BL;
using practice.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace practice
{
    public partial class CustfeedbackPanel : UserControl
    {
        public CustfeedbackPanel()
        {
            InitializeComponent();
        }
        private void btnaddfeedback_Click(object sender, EventArgs e)
        {
            bool conDigit = txtbestmed.Text.Any(char.IsDigit);
            if (!string.IsNullOrEmpty(txtbestmed.Text) && !string.IsNullOrEmpty(txtfeedback.Text))
            {
                if (conDigit == false)
                {

                    feedback feed = new feedback(txtUsername.Text, txtbestmed.Text, txtfeedback.Text);
                    feedbackDL.additemInList(feed);
                    feedbackDL.writeDataInFile();
                    MessageBox.Show("FeedBack Added successfuly");
                    txtUsername.Text = " ";
                    txtbestmed.Text = " ";
                    txtfeedback.Text = " ";

                }
                else
                {
                    MessageBox.Show("name of medicine can't have integers.");
                }
            }
            else
            {
                MessageBox.Show("Text Boxes are empty");
            }
        }

        private void CustfeedbackPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
