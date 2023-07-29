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
using practice.DL;
using practice.BL;

namespace practice
{
    public partial class AdminControlRead : UserControl
    {
        public AdminControlRead()
        {
            InitializeComponent();
        }
        int selectedRow = 0;
        private void AdminControlRead_Load(object sender, EventArgs e)
        {
            dataGridViewmenu.CellClick += dataGridViewmenu_CellContentClick_1;
            dataGridViewmenu.DataSource = productDL.itemList;
            dataGridViewmenu.Refresh();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validname = true;
            bool nameExist = true;
            validname = validations.validName(txtName.Text);
            bool conDigit = txtName.Text.Any(char.IsDigit);
            nameExist = validations.validnameExist(txtName.Text);
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {
                if (validname == false)
                {
                    if (conDigit == false)
                    {
                        if (nameExist == false)
                        {
                            product prd = new product(txtName.Text, int.Parse(txtPrice.Text), int.Parse(txtStock.Text));
                            productDL.additemInList(prd);
                            productDL.writeDataInFile();
                            refresh();
                            txtName.Text = " ";
                            txtPrice.Text = " ";
                            txtStock.Text = " ";
                        }
                        else
                        {
                            MessageBox.Show("medicine already exist");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name cannot take integer");
                    }
                }
                else
                {
                    MessageBox.Show("Medicine name should contain at least 3 characters .");
                }
            }
            else
            {
                MessageBox.Show("Text Boxes are empty");
            }
        }
        private void refresh()
        {
            dataGridViewmenu.DataSource = null;
            dataGridViewmenu.DataSource = productDL.itemList;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridViewmenu.CurrentCell.RowIndex;
            productDL.itemList.RemoveAt(selectedRow);
            refresh();
            productDL.writeDataInFile();
            txtName.Text = " ";
            txtPrice.Text = " ";
            txtStock.Text = " ";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selectedRow = dataGridViewmenu.CurrentCell.RowIndex;
            DataGridViewRow newRow = dataGridViewmenu.Rows[selectedRow];
            newRow.Cells[0].Value = txtName.Text;
            newRow.Cells[1].Value = txtPrice.Text;
            newRow.Cells[2].Value = txtStock.Text;
            productDL.writeDataInFile();
            refresh();
        }
        public DataGridViewRow row;
        private void dataGridViewmenu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = dataGridViewmenu.Rows[e.RowIndex];
            txtName.Text = row.Cells[0].Value.ToString();
            txtPrice.Text = row.Cells[1].Value.ToString();
            txtStock.Text = row.Cells[2].Value.ToString();
        }
    }
}
