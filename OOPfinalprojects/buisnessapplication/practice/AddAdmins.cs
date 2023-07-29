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
    public partial class AddAdmins : UserControl
    {
        public AddAdmins()
        {
            InitializeComponent();
        }
        private void AddAdmins_Load(object sender, EventArgs e)
        {
            txtAdminPassword.PasswordChar = '.';
            btnopeneye.BringToFront();
        }
        private void clearadminDataFromForm()
        {
            txtAdminName.Text = "";
            txtAdminPassword.Text = "";
        }
        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                bool specialchar = false;
                bool isnameValid = true;
                Form form = new Form();
                practice.BL.User user = new practice.BL.User(txtAdminName.Text, txtAdminPassword.Text);
                bool NamecontainPun = txtAdminName.Text.Any(char.IsPunctuation);
                specialchar = validations.validspecialPassword(txtAdminPassword.Text);
                isnameValid = validations.validName(txtAdminName.Text);
                bool isNameUnique = validations.isUserUnique(txtAdminName.Text);
                if (!string.IsNullOrEmpty(txtAdminName.Text) && !string.IsNullOrEmpty(txtAdminPassword.Text))
                {
                    if (!NamecontainPun)

                    {
                        if (isNameUnique)
                        {
                            if (isnameValid == false)
                            {
                                bool containsNumber = txtAdminName.Text.Any(char.IsDigit);
                                if (containsNumber)
                                {
                                    MessageBox.Show("Name cannot contain numbers");
                                }
                                bool passLengthValid = validations.isPasswordValid(txtAdminPassword.Text);
                                bool containWhite = txtAdminPassword.Text.Any(char.IsWhiteSpace);
                                if (passLengthValid)
                                {
                                    if (specialchar == true)
                                    {
                                        if (containWhite == false)
                                        {
                                            if (!string.IsNullOrEmpty(txtAdminName.Text) && !string.IsNullOrEmpty(txtAdminPassword.Text))
                                            {
                                                practice.BL.Admin userObj = new practice.BL.Admin(txtAdminName.Text, txtAdminPassword.Text);
                                                UserDL.storeDataInList(userObj);
                                                UserDL.storeDataInFile(userObj);
                                                clearadminDataFromForm();
                                            }
                                            else
                                            {
                                                MessageBox.Show("enter data in text boxes input cannot be empty.");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Password can't have space.");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("password must contains a special character.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Password Length must be of 8 character or more.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Name should be greater than three characters");
                            }
                        }
                        else
                        {
                            MessageBox.Show("this user exist already enter a unique name");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name can't have punctuation. ");
                    }
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("INVALID " + ex.Message);
            }
        }
        private void btnopeneye_Click(object sender, EventArgs e)
        {
            txtAdminPassword.PasswordChar = '\0';
            btncloseeye.Visible = true;
            btnopeneye.Visible = false;
        }
        private void btncloseeye_Click(object sender, EventArgs e)
        {
            txtAdminPassword.PasswordChar = '.';
            btnopeneye.Visible = true;
            btncloseeye.Visible = false;
        }
    }
}
