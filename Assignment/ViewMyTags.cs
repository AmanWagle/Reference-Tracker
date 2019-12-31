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
    public partial class ViewMyTags : Form
    {
        private int userId;
        public ViewMyTags(int UId)
        {
            userId = UId;
            InitializeComponent();
        }

        private void View_Tags_Load(object sender, EventArgs e)
        {
            loadTag();
        }

        private void loadTag()
        {
            try
            {
                string qry = "select * from tbl_Tags where UserId =" + userId;
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
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int tag_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            if (command == "Edit")
            {
                Edit_Tags et = new Edit_Tags(tag_Id);
                et.UserID = userId;
                this.Close();
                et.Show();
            }
            else if (command == "Delete")
            {
                try
                {
                    string qry = "delete from [tbl_Tags] where Tag_Id =" + tag_Id;
                    DatabaseCon dbcon = new DatabaseCon();
                    dbcon.Query = qry;
                    dbcon.ExecuteQuery();
                    MessageBox.Show("Data deleted successfully");

                    loadTag();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            else if (command == "Tagged Article")
            {
                try
                {
                    string qry = "select Tag from [tbl_Tags] where Tag_Id =" + tag_Id;
                    DatabaseCon dbcon = new DatabaseCon();
                    dbcon.Query = qry;
                    DataTable dt = dbcon.GetData();
                    string Tag = dt.Rows[0]["Tag"].ToString();

                    View_myReferences vr = new View_myReferences(userId);
                    vr.Tag = Tag;
                    this.Close();
                    vr.Show();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Home h = new Home(userId);
            h.Show();
        }
    }
}
