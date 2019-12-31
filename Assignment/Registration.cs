using System;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void lblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            User u = new User();
            string gender = "";

            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                gender = "Female";
            }
            else if (radioOthers.Checked)
            {
                gender = "Others";
            }

            u.Fname = txtFname.Text;
            u.Surename = txtSurname.Text;
            u.Gender = gender;
            u.Address = txtAddress.Text;
            u.Phone = txtPhone.Text;
            u.Dob = datetimepicker_dob.Value.Date;
            u.Email = txtEmail.Text;
            u.Password = txtPassword.Text;

            UserValidation uv = new UserValidation();
            if(uv.emptyValidation(txtFname.Text)== true && uv.emptyValidation(txtSurname.Text)== true)
            {
                if (!string.IsNullOrEmpty(gender))
                {
                    if (uv.emailValidation(txtEmail.Text) == true)
                    {
                        if (uv.CheckEmail(txtEmail.Text) == true)
                        {
                            if (uv.emptyValidation(txtPassword.Text) == true)
                            {
                                if (uv.passwordValidation(txtPassword.Text, txtRepassword.Text) == true)
                                {
                                    u.adduser();
                                    MessageBox.Show("User Registrated Sucessfully.");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Password and Confrim Password doesn't match.");
                                    txtPassword.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please don't leave Password empty.");
                                txtPassword.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("The email address already exists.");
                            txtEmail.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Email.");
                        txtEmail.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please choose your gender.");
                    radioMale.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Full Name");
                txtFname.Focus();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login l = new Login();
            l.Show();
        }
    }
}
