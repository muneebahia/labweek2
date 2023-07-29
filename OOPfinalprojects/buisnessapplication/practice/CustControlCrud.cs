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
using System.Xml.Linq;
using practice.DL;

namespace practice
{
    public partial class CustControlCrud : UserControl
    {
        int selectedrow = 0;
        public CustControlCrud()
        {
            InitializeComponent();
        }
        private void CustControlCrud_Load(object sender, EventArgs e)
        {
            dataGridViewMelist.CellClick += dataGridViewMelist_CellContentClick;
            dataGridViewCart.CellClick += DataGridViewCart_CellClick;
            dataGridViewMelist.CellEnter += dataGridViewMelist_CellEnter;
            dataGridViewCart.CellEnter += dataGridViewCart_CellEnter;

            dataGridViewMelist.DataSource = null;
            dataGridViewMelist.DataSource = productDL.itemList;
            productDL.itemList = productDL.itemList.OrderByDescending(i => i.MedicinePrice).ToList();


            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = customerDL.Cart;
            customerDL.Cart = customerDL.Cart.OrderByDescending(i => i.MedicinePrice).ToList();
            txtNameCart.Enabled = false;
            txtPriceCart.Enabled = false;
        }
        private void DataGridViewCart_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridViewCart.Rows[e.RowIndex];
            txtNameCart.Text = selectedRow.Cells[0].Value.ToString();
            txtPriceCart.Text = selectedRow.Cells[1].Value.ToString();
            txtQuantityCart.Text = selectedRow.Cells[2].Value.ToString();
        }
        private void btnAddCart_Click(object sender, EventArgs e)
        {
            bool medicineAddedToCart = false;
            bool isquantityavaiable = false;
            bool validName = productDL.checkName(txtNameCart.Text);
            if (validName)
            {
                foreach (var i in productDL.itemList)
                {
                    if (txtNameCart.Text == i.MedicineName)
                    {
                        if (int.Parse(txtQuantityCart.Text) <= i.Quantity)
                        {
                            isquantityavaiable = true;
                            i.Quantity = i.Quantity - int.Parse(txtQuantityCart.Text);

                            foreach (var j in customerDL.Cart)
                            {
                                if (txtNameCart.Text == j.MedicineName)
                                {
                                    j.Quantity = j.Quantity + int.Parse(txtQuantityCart.Text);
                                    medicineAddedToCart = true;
                                    break;
                                }
                            }
                            if (!medicineAddedToCart)
                            {
                                product obj = new product(txtNameCart.Text, int.Parse(txtPriceCart.Text), int.Parse(txtQuantityCart.Text));
                                customerDL.addmedicinesinCustList(obj);
                            }
                        }
                    }
                }
                if (isquantityavaiable == false)
                {
                    Console.WriteLine("Insufficient quantity of selected medicine.");
                }
            }
            else
            {
                MessageBox.Show("Item not found!!!");
            }
            productDL.writeDataInFile();
            refresh();
            txtNameCart.Text = " ";
            txtPriceCart.Text = " ";
            txtQuantityCart.Text = " ";
        }
        private void refresh()
        {
            dataGridViewCart.DataSource = null;
            dataGridViewCart.DataSource = customerDL.Cart;
        }
        public DataGridViewRow selectedRow;
        private void dataGridViewMelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = dataGridViewMelist.Rows[e.RowIndex];
            txtNameCart.Text = selectedRow.Cells[0].Value.ToString();
            txtPriceCart.Text = selectedRow.Cells[1].Value.ToString();
            txtQuantityCart.Text = selectedRow.Cells[2].Value.ToString();
        }
        private void dataGridViewCart_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewMelist.ClearSelection();
        }
        private void dataGridViewMelist_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewCart.ClearSelection();
        }

        private void btnUpdateCart_Click(object sender, EventArgs e)
        {
            selectedrow = dataGridViewCart.CurrentCell.RowIndex;
            DataGridViewRow newRow = dataGridViewCart.Rows[selectedrow];
            newRow.Cells[0].Value = txtNameCart.Text;
            newRow.Cells[1].Value = txtPriceCart.Text;
            newRow.Cells[2].Value = txtQuantityCart.Text;
            productDL.writeDataInFile();
            refresh();
        }

        private void btnDelCart_Click(object sender, EventArgs e)
        {
            selectedrow = dataGridViewCart.CurrentCell.RowIndex;
            customerDL.Cart.RemoveAt(selectedrow);
            refresh();
            productDL.writeDataInFile();
            txtNameCart.Text = " ";
            txtPriceCart.Text = " ";
            txtQuantityCart.Text = " ";
        }
    }
}

