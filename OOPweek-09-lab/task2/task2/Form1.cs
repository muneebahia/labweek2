﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCheckNext_Click(object sender, EventArgs e)
        {
            if(chekSignIn.Checked)
            {
                this.Hide();
                SignIn form = new SignIn();
                form.Show();
            }
            if (checkBox2.Checked)
            {
                this.Hide();
                SignUp form = new SignUp();
                form.Show();
            }
        }

        private void chekSignIn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
