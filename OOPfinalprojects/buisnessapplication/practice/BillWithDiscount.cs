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

namespace practice
{
    public partial class BillWithDiscount : UserControl
    {
        public BillWithDiscount()
        {
            InitializeComponent();
        }
        private void BillWithDiscount_Load(object sender, EventArgs e)
        {
            dataGridViewbillcart.DataSource = null;
            dataGridViewbillcart.DataSource = customerDL.Cart;
            customerDL.Cart = customerDL.Cart.OrderByDescending(i => i.MedicinePrice).ToList();
            float bill = customerDL.calculateBill();
            float BillWithDiscount = discountDL.finalBillWithDiscount(bill);
            int index = discountDL.getIndex();
            if (bill < discountDL.discounts[index - 1].DiscountPrice)
            {
                MessageBox.Show("At that time no discount is available!!!!!");
            }

            lblOrignalBill.Text = "your orignal bill is:" + bill;
            lbldiscount.Text = discountDL.discounts[index - 1].DiscountPercent + " %" + " discount is available at the bill greater than" + " " + discountDL.discounts[index - 1].DiscountPrice;
            lblbill.Text = "your final bill is:" + BillWithDiscount;
        }
    }
}
