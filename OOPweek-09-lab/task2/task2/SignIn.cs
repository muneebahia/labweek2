using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task2.BL;
using task2.DL;

namespace task2
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void ClearDataFromForm()
        {
            lblname.Text = "";
            lblpassword.Text = "";
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string userName = lblname.Text;
            string Password = lblpassword.Text;
            User user = new User(userName, Password);
            User Valid = UserDL.signin(user);
            if(Valid!=null)
            {
                MessageBox.Show("User is Valid");
            }
            else
            {
                MessageBox.Show("InvalidUser");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1 ();
            form.Show();
        }
    }
}
