﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblClickhere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration r = new Registration();
            r.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            loginUserdata l = new loginUserdata();
            DataTable dt = l.login(Email, Password);

            if(dt.Rows.Count>0)
            {
                int user_id = int.Parse(dt.Rows[0][0].ToString());
                Home h = new Home(user_id);
                this.Hide();
                h.Show();
            }
            else
            {
                MessageBox.Show ("Invalid Email or Password. Try again.");
            }
        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                string a = txtPassword.Text;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
