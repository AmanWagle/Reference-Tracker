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
    public partial class Change_Password : Form
    {
        private int userid;

        public Change_Password(int user_id)
        {
            userid = user_id;
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            loginUserdata l = new loginUserdata();
            DataTable dt = l.userdata(userid);
            if (dt.Rows[0]["Password"].ToString() == txtCurrentpw.Text)
            {
                if(txtNewpw.Text == txtConfirmpw.Text)
                {
                    DialogResult result1 = MessageBox.Show("Are you sure you want to Change password?",
                    "The Question", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result1 == DialogResult.Yes)
                    {
                        try
                        {
                            string qry = "Update tbl_User set Password ='" + txtNewpw.Text + "' where ID =" 
                                + userid;
                            DatabaseCon dbcon = new DatabaseCon();
                            dbcon.Query = qry;
                            dbcon.ExecuteQuery();

                            MessageBox.Show("Password changed sucessfully.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            Profile p = new Profile(userid);
                            p.Show();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        //nothing
                    } 


                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Current Password.");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile p = new Profile(userid);
            p.Show();
        }
    }
}
