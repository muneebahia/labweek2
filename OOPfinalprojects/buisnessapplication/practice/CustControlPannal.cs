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
    public partial class CustControlPannal : Form
    {
        public CustControlPannal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Set the MinimumSize of the form to the size of the screen
            this.MinimumSize = Screen.PrimaryScreen.Bounds.Size;
        }
        private void addAdminControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCustomer.Controls.Clear();
            panelCustomer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            sortedlistpannal list = new sortedlistpannal();
            addAdminControl(list);
        }
        private void btnCustCart_Click(object sender, EventArgs e)
        {
            CustControlCrud list = new CustControlCrud();
            addAdminControl(list);
        }

        private void btnFeedbackCust_Click(object sender, EventArgs e)
        {
            CustfeedbackPanel feedlist = new CustfeedbackPanel();
            addAdminControl(feedlist);
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            CustDiscountPanel discountlist = new CustDiscountPanel();
            addAdminControl(discountlist);

        }

        private void bthBill_Click(object sender, EventArgs e)
        {
            BillWithDiscount bill = new BillWithDiscount();
            addAdminControl(bill);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnbacksignin_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn form = new SignIn();
            form.Show();
        }
    }
}
