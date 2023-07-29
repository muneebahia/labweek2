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
using practice.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace practice
{
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Set the MinimumSize of the form to the size of the screen
            this.MinimumSize = Screen.PrimaryScreen.Bounds.Size;
        }
        private void btnHighestPriceItem_Click(object sender, EventArgs e)
        {
            productDL.itemList = productDL.itemList.OrderByDescending(i => i.MedicinePrice).ToList();
            CostlymediicinePannal costly = new CostlymediicinePannal();
            addAdminControl(costly);
        }
        private void addAdminControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelAdmin.Controls.Clear();
            panelAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnRead_Click_1(object sender, EventArgs e)
        {
            AdminControlRead adminControlRead = new AdminControlRead();
            addAdminControl(adminControlRead);
        }
        private void btnAddCust_Click(object sender, EventArgs e)
        {
            AdminShowUsers userslist = new AdminShowUsers();
            addAdminControl(userslist);
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            sortedlistpannal sortedlist = new sortedlistpannal();
            addAdminControl(sortedlist);
        }
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            AdminFeedbackPanel feedback = new AdminFeedbackPanel();
            addAdminControl(feedback);
        }
        private void btnGivediscount_Click(object sender, EventArgs e)
        {
            adminGiveDiscount discount = new adminGiveDiscount();
            addAdminControl(discount);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddAdmins admin = new AddAdmins();
            addAdminControl(admin);
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

        private void AdminMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
