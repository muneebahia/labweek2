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
    public partial class changePassword : Form
    {
        public changePassword()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Set the MinimumSize of the form to the size of the screen
            this.MinimumSize = Screen.PrimaryScreen.Bounds.Size;
        }
        private void btnpasswordUpdate_Click(object sender, EventArgs e)
        {
            bool specialchar = false;
            bool isValidNameAndPassword = validations.ValidPassword(txtoldName.Text, txtoldPassword.Text);
            if (isValidNameAndPassword)
            {
                foreach (var i in UserDL.userList)
                {
                    if (txtoldName.Text == i.Name && txtoldPassword.Text == i.Password)
                    {
                        bool passLengthValid = validations.isPasswordValid(txtnewPassword.Text);
                        bool containWhite = txtnewPassword.Text.Any(char.IsWhiteSpace);
                        specialchar = validations.validspecialPassword(txtnewPassword.Text);
                        if (passLengthValid)
                        {
                            if (specialchar == true)
                            {
                                if (containWhite == false)
                                {
                                    i.Password = txtnewPassword.Text;
                                    MessageBox.Show("Password Updated Successsfully.");
                                    this.Hide();
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Password can't have spaces.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("password must contains a special character.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password Length must be of 8 characters or more. ");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter Correct Old Name and Password.");
            }
            UserDL.reWriteFile();
        }
        private void changePassword_Load(object sender, EventArgs e)
        {
            txtoldPassword.PasswordChar = '.';
            txtnewPassword.PasswordChar = '.';
            btnopenneweye.BringToFront();
            btnopenoldeye.BringToFront();
        }

        private void btnopenoldeye_Click(object sender, EventArgs e)
        {
            txtoldPassword.PasswordChar = '\0';
            btncloseoldeye.Visible = true;
            btnopenoldeye.Visible = false;
        }

        private void btncloseoldeye_Click(object sender, EventArgs e)
        {

            txtoldPassword.PasswordChar = '.';
            btnopenoldeye.Visible = true;
            btncloseoldeye.Visible = false;
        }

        private void btncloseneweye_Click(object sender, EventArgs e)
        {
            txtnewPassword.PasswordChar = '.';
            btnopenneweye.Visible = true;
            btncloseneweye.Visible = false;
        }

        private void btnopenneweye_Click(object sender, EventArgs e)
        {
            txtnewPassword.PasswordChar = '\0';
            btncloseneweye.Visible = true;
            btnopenneweye.Visible = false;

        }

    }
}
