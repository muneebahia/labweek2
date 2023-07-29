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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Set the MinimumSize of the form to the size of the screen
            this.MinimumSize = Screen.PrimaryScreen.Bounds.Size;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            UserDL.readData();
            User user = new User(txtName.Text, txtPassword.Text);
            User User = UserDL.signInIfValid(user);
            if (User != null)
            {
                if (User.GetType() == typeof(Customer))
                {
                    CustControlPannal custmenu = new CustControlPannal();
                    custmenu.Show();
                    this.Hide();
                }
                else if (User.GetType() == typeof(Admin))
                {
                    AdminMenuForm menu = new AdminMenuForm();
                    menu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong Credentials.");
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm Login = new LoginForm();
            Login.Show();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changePassword forgotpassword = new changePassword();
            forgotpassword.Show();
        }
        private void SignIn_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '.';
            btnopeneye.BringToFront();
        }

        private void btnopeneye_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btncloseeye.Visible = true;
            btnopeneye.Visible = false;
        }

        private void btncloseeye_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '.';
            btnopeneye.Visible = true;
            btncloseeye.Visible = false;
        }
    }
}
