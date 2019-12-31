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
    public partial class Profile : Form
    {
        private int userid;
        public Profile(int user_id)
        {
            userid = user_id;
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit_Profile edit = new Edit_Profile(userid);
            this.Close();
            edit.Show();
        }

        private void btn_changepw_Click(object sender, EventArgs e)
        {
            Change_Password changepw = new Change_Password(userid);
            this.Close();
            changepw.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Home h = new Home(userid);
            h.Show();
            this.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            loginUserdata l = new loginUserdata();
            DataTable dt = l.userdata(userid);
            Name = dt.Rows[0]["First_Name"].ToString();

            Label lbl_head = new Label();
            lbl_head.AutoSize = true;
            lbl_head.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)
                ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), 
                System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbl_head.Location = new System.Drawing.Point(197, 21);
            lbl_head.Name = "label10";
            lbl_head.Size = new System.Drawing.Size(414, 72);
            lbl_head.TabIndex = 98;
            lbl_head.Text = "Hello, " + Name;
            this.Controls.Add(lbl_head);

            int y = 108;
            for (int i = 1; i < 8; i++)
            {
                Label lbl_i = new Label();
                lbl_i.AutoSize = true;
                lbl_i.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl_i.Location = new System.Drawing.Point(350, y);
                lbl_i.Size = new System.Drawing.Size(76, 35);
                lbl_i.TabIndex = 101;
                if (i==1)
                    lbl_i.Text = dt.Rows[0]["First_Name"].ToString(); 
                else if (i==2)
                    lbl_i.Text = dt.Rows[0]["Surname"].ToString();
                else if (i==3)
                    lbl_i.Text = dt.Rows[0]["Gender"].ToString();
                else if (i == 4)
                    lbl_i.Text = dt.Rows[0]["Dob"].ToString();
                else if (i == 5)
                    lbl_i.Text = dt.Rows[0]["Address"].ToString();
                else if (i == 6)
                    lbl_i.Text = dt.Rows[0]["Email"].ToString();
                else if (i == 7)
                    lbl_i.Text = dt.Rows[0]["Phone"].ToString();

                this.Controls.Add(lbl_i);
                y = y + 45;
            }
            this.ActiveControl = btn_back;
        }
    }
}
