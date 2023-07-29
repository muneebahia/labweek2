using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practice.DL;

namespace practice
{
    public partial class sortedlistpannal : UserControl
    {
        public sortedlistpannal()
        {
            InitializeComponent();
        }

        private void sortedlistpannal_Load(object sender, EventArgs e)
        {
            dataGridViewsortedmenu.DataSource = null;
            dataGridViewsortedmenu.DataSource = productDL.itemList;
            productDL.itemList = productDL.itemList.OrderByDescending(i => i.MedicinePrice).ToList();
        }
    }
}
