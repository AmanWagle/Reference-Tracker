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
    public partial class Edit_Tags : Form
    {
        private int tagId;
        public Edit_Tags(int tId)
        {
            tagId = tId;
            InitializeComponent();
        }

        public int UserID
        {
            get;
            set;
        }

        private void Edit_Tags_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from tbl_Tags where Tag_Id =" + tagId;
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();
                if (dt.Rows.Count > 0)
                {
                    txtTag.Text = dt.Rows[0]["Tag"].ToString();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update tbl_Tags set Tag='" + txtTag.Text + "' where Tag_Id= " + tagId;
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                dbcon.ExecuteQuery();
                MessageBox.Show("Done");

                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_Tags_FormClosing(object sender, FormClosingEventArgs e)
        {
            ViewMyTags v = new ViewMyTags(UserID);
            v.Show();
        }
    }
}
