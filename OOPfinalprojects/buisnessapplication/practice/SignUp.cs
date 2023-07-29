using Microsoft.VisualBasic.ApplicationServices;
using practice.BL;
using practice.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Set the MinimumSize of the form to the size of the screen
            this.MinimumSize = Screen.PrimaryScreen.Bounds.Size;
        }
        private void clearDataFromForm()
        {
            txtName.Text = "";
            txtPassword.Text = "";
        }
        private void btnNextSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                bool isnameValid = true;
                bool specialchar = false;
                bool isNameUnique = false;
                Form form = new Form();
                practice.BL.User user = new practice.BL.User(txtName.Text, txtPassword.Text);
                bool NamecontainPun = txtName.Text.Any(char.IsPunctuation);
                isnameValid = validations.validName(txtName.Text);
                isNameUnique = validations.isUserUnique(txtName.Text);
                if (!NamecontainPun)

                {
                    if (isNameUnique == true)
                    {
                        if (isnameValid == false)
                        {
                            bool containsNumber = txtName.Text.Any(char.IsDigit);
                            if (containsNumber == true)
                            {
                                MessageBox.Show("Name cannot contain numbers");
                            }
                            bool passLengthValid = validations.isPasswordValid(txtPassword.Text);
                            bool containWhite = txtPassword.Text.Any(char.IsWhiteSpace);
                            specialchar = validations.validspecialPassword(txtPassword.Text);
                            if (passLengthValid)
                            {
                                if (specialchar == true)
                                {
                                    if (containWhite == false)
                                    {
                                        if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                                        {
                                            practice.BL.Customer userObject = new practice.BL.Customer(txtName.Text, txtPassword.Text);
                                            UserDL.storeDataInList(userObject);
                                            UserDL.storeDataInFile(userObject);
                                            clearDataFromForm();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Input cannot be empty");

                                        }
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
                        else
                        {
                            MessageBox.Show("Name can't be less than 3 characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Already Exists");
                    }
                }
                else
                {
                    MessageBox.Show("Name can't have punctuations marks");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid: " + ex.Message);
            }
        }
        private void btnBackSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm form = new LoginForm();
            form.Show();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '.';
            btnopeneye.BringToFront();
        }
        private void btncloseeye_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '.';
            btnopeneye.Visible = true;
            btncloseeye.Visible = false;
        }
        private void btnopeneye_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            btncloseeye.Visible = true;
            btnopeneye.Visible = false;
        }
    }
}
