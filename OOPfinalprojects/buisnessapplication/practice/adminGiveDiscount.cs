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
    public partial class adminGiveDiscount : UserControl
    {
        int selectedRow = 0;
        public adminGiveDiscount()
        {
            InitializeComponent();
        }
        private void btnadddiscount_Click(object sender, EventArgs e)
        {
            if (discountDL.discounts.Count == 0)
            {
                discount dis = new discount(float.Parse(txtdiscountprice.Text), float.Parse(txtdiscountpercent.Text));
                discountDL.addInList(dis);
                discountDL.writeDiscountDataInFile();
                MessageBox.Show("Discount Added successfuly");
            }
            else if (discountDL.discounts.Count > 0)
            {
                btnadddiscount.Enabled = false;
                MessageBox.Show("Discount already added");
            }
            txtdiscountprice.Text = " ";
            txtdiscountpercent.Text = " ";
        }
        private void refresh()
        {
            dataGridViewgivecustdiscount.DataSource = null;
            dataGridViewgivecustdiscount.DataSource = discountDL.discounts;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridViewgivecustdiscount.CurrentCell.RowIndex;
            DataGridViewRow newRow = dataGridViewgivecustdiscount.Rows[selectedRow];
            newRow.Cells[0].Value = txtdiscountprice.Text;
            newRow.Cells[1].Value = txtdiscountpercent.Text;
            discountDL.writeDiscountDataInFile();
            refresh();
        }
        public DataGridViewRow row;
        private void dataGridViewgivecustdiscount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridViewgivecustdiscount.Rows[e.RowIndex];
            txtdiscountprice.Text = row.Cells[0].Value.ToString();
            txtdiscountpercent.Text = row.Cells[1].Value.ToString();
        }
        private void adminGiveDiscount_Load(object sender, EventArgs e)
        {
            dataGridViewgivecustdiscount.CellClick += dataGridViewgivecustdiscount_CellContentClick;
            dataGridViewgivecustdiscount.DataSource = discountDL.discounts;
            dataGridViewgivecustdiscount.Refresh();
        }
    }
}
