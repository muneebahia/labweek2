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
    public partial class AdminShowUsers : UserControl
    {
        public AdminShowUsers()
        {
            InitializeComponent();
        }
        private void AdminShowUsers_Load(object sender, EventArgs e)
        {
            dataGridViewadminshowusers.DataSource = null;
            dataGridViewadminshowusers.AutoGenerateColumns = false;

            dataGridViewadminshowusers.Columns.Add("NameColumn", "Name");
            dataGridViewadminshowusers.Columns.Add("PasswordColumn", "Password");

            dataGridViewadminshowusers.Columns["NameColumn"].DataPropertyName = "Name";
            dataGridViewadminshowusers.Columns["PasswordColumn"].DataPropertyName = "Password";

            dataGridViewadminshowusers.DataSource = getList();
            dataGridViewadminshowusers.Refresh();
        }
        private List<Customer> getList()
        {
            List<Customer> list = new List<Customer>();
            foreach (var i in UserDL.userList)
            {
                if (i is Customer)
                {
                    list.Add((Customer)i);
                }
            }
            return list;
        }
    }
}
