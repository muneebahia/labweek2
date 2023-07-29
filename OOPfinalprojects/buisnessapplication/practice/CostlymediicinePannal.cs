using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using practice.BL;
using practice.DL;

namespace practice
{
    public partial class CostlymediicinePannal : UserControl
    {
        public CostlymediicinePannal()
        {
            InitializeComponent();
        }
        private void CostlymediicinePannal_Load(object sender, EventArgs e)
        {
            costlydata.DataSource = null;
            productDL.itemList = productDL.itemList.OrderByDescending(i => i.MedicinePrice).ToList();
            List<product> singleRowList = new List<product>();
            singleRowList.Add(productDL.itemList[0]);
            costlydata.DataSource = singleRowList;
            costlydata.Refresh();

        }
    }
}
