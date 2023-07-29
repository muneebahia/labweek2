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

namespace practice
{
    public partial class CustDiscountPanel : UserControl
    {
        public CustDiscountPanel()
        {
            InitializeComponent();
        }
        private void CustDiscountPanel_Load(object sender, EventArgs e)
        {
            dataGridViewcustdiscount.DataSource = null;
            dataGridViewcustdiscount.DataSource = discountDL.discounts;
            dataGridViewcustdiscount.Refresh();
        }
    }
}
