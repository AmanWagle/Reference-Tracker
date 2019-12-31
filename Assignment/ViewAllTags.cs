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
    public partial class ViewAllTags : Form
    {
        public ViewAllTags()
        {
            InitializeComponent();
        }

        private void ViewAllTags_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from [tbl_Tags]";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            int tag_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            if (command == "Tagged Article")
            {
                try
                {
                    string qry = "select Tag from [tbl_Tags] where Tag_Id =" + tag_Id;
                    DatabaseCon dbcon = new DatabaseCon();
                    dbcon.Query = qry;
                    DataTable dt = dbcon.GetData();
                    string Tag = dt.Rows[0]["Tag"].ToString();

                    viewAllReferences var = new viewAllReferences();
                    var.Tag = Tag;
                    var.Show();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
