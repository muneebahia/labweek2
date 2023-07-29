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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.Sizable;

            // Set the MinimumSize of the form to the size of the screen
            this.MinimumSize = Screen.PrimaryScreen.Bounds.Size;
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdbtnSignUp.Checked)
            {
                SignUp signup = new SignUp();
                signup.Show();
                this.Hide();
            }
            else if (rdbtnSignIn.Checked)
            {
                SignIn signin = new SignIn();
                signin.Show();
                this.Hide();
            }
            else if(radioButton1.Checked)
            {
                this.Hide();
            }
        }

       
    }
}
