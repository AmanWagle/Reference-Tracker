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
    public partial class Edit_Profile : Form
    {
        private int userid;
        public Edit_Profile(int user_id)
        {
            userid = user_id;
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
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
            else
            {
                MessageBox.Show("Please choose your gender.");
            }

            UserValidation uv = new UserValidation();
            if (uv.emptyValidation(txtFname.Text) == true && uv.emptyValidation(txtSurname.Text) == true)
            {
                if (!string.IsNullOrEmpty(gender))
                {
                    try
                    {
                        string qry = "update tbl_User set First_Name ='" + txtFname.Text + "', Surname ='" 
                            + txtSurname.Text + "', Address ='" + txtAddress.Text + "', Gender ='" + gender 
                            + "', Phone ='" + txtPhone.Text + "', Dob ='" + Datetimepicker_dob.Value.Date 
                            + "' where ID = " + userid;
                        DatabaseCon dbcon = new DatabaseCon();
                        dbcon.Query = qry;
                        dbcon.ExecuteQuery();
                        MessageBox.Show("Data Edited");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            loginUserdata l = new loginUserdata();
            DataTable dt = l.userdata(userid);
            if (dt.Rows.Count > 0)
            {
                txtFname.Text = dt.Rows[0]["First_Name"].ToString();
                txtSurname.Text = dt.Rows[0]["Surname"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                Datetimepicker_dob.Value = Convert.ToDateTime(dt.Rows[0]["Dob"]);
                if (dt.Rows[0]["Gender"].ToString() == "Male")
                    radioMale.Checked = true;
                else if (dt.Rows[0]["Gender"].ToString() == "Female")
                    radioFemale.Checked = true;
                else if (dt.Rows[0]["Gender"].ToString() == "Others")
                    radioOthers.Checked = true;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Profile p = new Profile(userid);
            p.Show();
        }
    }
}
