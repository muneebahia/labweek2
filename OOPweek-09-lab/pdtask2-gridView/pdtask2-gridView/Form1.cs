using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdtask2_gridView
{
   
    public partial class Form1 : Form
    {
         List<User> U = new List<User>();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = U;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            User user = new User("muneeba", "muneeba@123", "Admin");
            User user1 = new User("zainab", "zainab@123", "Customer");
            User user2 = new User("tayyba", "tayyba@123", "Manager");
            U.Add(user);
            U.Add(user1);
            U.Add(user2);
            dataGridView1.DataSource = U;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string UserName = txtname.Text;
            string Password = txtpassword.Text;
            string role = txtrole.Text;
            User userdata = new User(UserName, Password, role);
            U.Add(userdata);
            refresh();
            MessageBox.Show("Added Successfully!!!!");
        }
    }
}
