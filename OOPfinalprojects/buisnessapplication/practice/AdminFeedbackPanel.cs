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
using practice.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace practice
{
    public partial class AdminFeedbackPanel : UserControl
    {
        public AdminFeedbackPanel()
        {
            InitializeComponent();
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            dataGridViewadfeedback.DataSource = null;
            dataGridViewadfeedback.DataSource = feedbackDL.feedbacklist;
            dataGridViewadfeedback.Refresh();
        }
        public DataGridViewRow row;
    }
}
