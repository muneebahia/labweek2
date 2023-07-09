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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void ClearDataFromForm()
        {
            lblname.Text = "";
            lblpassword.Text = "";
            lblRole.Text="";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {  
            bool validname = false;
            string userName = lblname.Text;
            string Password = lblpassword.Text;
            string Role=lblRole.Text;
            string path = "user.txt";
            validname = lblname.Text.Any(char.IsDigit);
            
            if(!validations.validName(userName))
            {


                    if (validations.validlengthPassword(Password))
                    {
                        if (validations.validspecialPassword(Password))
                        {
                            if (validations.validletterPassword(Password))
                            {
                                if (lblRole.Text == "Admin" || lblRole.Text == "Customer")
                                {
                                    User user = new User(userName, Password, Role);
                                    UserDL.storeDatainlist(user);
                                    UserDL.storeDatainfile(user, path);
                                    MessageBox.Show("Data Added Successfully");
                                    ClearDataFromForm();
                                }
                                else
                                {
                                    MessageBox.Show("invalid Role!!please enter Admin or Customer");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Password must have a letter");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Password must contain a special character.");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Password length must be greater than 8");
                    }
              
            }
            else
            {
                MessageBox.Show("name length must be greater than 3");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
