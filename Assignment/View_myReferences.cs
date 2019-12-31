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
    public partial class View_myReferences : Form
    {
        private int userid;
        public View_myReferences(int user_id)
        {
            userid = user_id;
            InitializeComponent();
        }

        public string Tag
        {
            get;
            set;
        }

        private void loadReferences()
        {
            try
            {
                string qry;
                if (Tag == null)
                {
                    qry = "select * from tbl_References where UserId =" + userid;
                    txtHeader.Text = " References you have added ";
                }
                else
                {
                    this.txtSearch.Hide();
                    this.pictureBox2.Hide();
                    qry = "select * from [tbl_References] where UserId=" + userid + " and Title like '%" 
                        + Tag + "%' or Authors_Fname like '%" + Tag + "%' or Authors_Lname like '%" + Tag 
                        + "%' or Document_type like '%" + Tag + "%' or Year like '%" + Tag 
                        + "%' or Publisher like '%" + Tag + "%' or Abstract like '%" + Tag 
                        + "%' or Name like '%" + Tag + "%' or Issue like '%" + Tag + "%' or Volume like '%" 
                        + Tag + "%' or Notes like '%" + Tag + "%'";
                    txtHeader.Text = " References that are tagged in ";
                }
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ref_id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);

            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (command == "Edit")
            {
                Edit_References er = new Edit_References(ref_id);
                er.userID = userid;
                this.Close();
                er.Show();
            }
            else if (command == "Delete")
            {
                try
                {
                    string qry = "delete from tbl_References where Ref_Id=" + ref_id;
                    DatabaseCon dbcon = new DatabaseCon();
                    dbcon.Query = qry;
                    dbcon.ExecuteQuery();
                    MessageBox.Show("Data deleted successfully");

                    loadReferences();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void View_References_Load(object sender, EventArgs e)
        {
            loadReferences();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                string search = txtSearch.Text;
                string qry = "select * from [tbl_References] where UserID = " + userid + "and Title like '%" 
                    + search + "%' or Authors_Fname like '%" + search + "%' or Authors_Lname like '%" 
                    + search + "%' or Document_type like '%" + search + "%' or Year like '%" + search 
                    + "%' or Publisher like '%" + search + "%' or Abstract like '%" + search 
                    + "%' or Name like '%" + search + "%' or Issue like '%" + search + "%' or Volume like '%" 
                    + search + "%' or Notes like '%" + search + "%'";
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (Tag != null)
            {
                ViewMyTags vmt = new ViewMyTags(userid);
                vmt.Show();
            }
            else
            {
                Home h = new Home(userid);
                h.Show();
            }
        }
    }
}
