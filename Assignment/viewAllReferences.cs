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
    public partial class viewAllReferences : Form
    {
        public viewAllReferences()
        {
            InitializeComponent();
        }
        public string tag
        {
            get;
            set;
        }

        private void viewAllReferences_Load(object sender, EventArgs e)
        {
            try
            {
                string qry;
                if (Tag == null)
                {
                    qry = "select * from [tbl_References]";
                    txtHeader.Text = " References added by every user ";
                }
                else
                {
                    qry = "select * from [tbl_References] where Title like '%" + Tag 
                        + "%' or Authors_Fname like '%" + Tag + "%' or Authors_Lname like '%" 
                        + Tag + "%' or Document_type like '%" + Tag + "%' or Year like '%" 
                        + Tag + "%' or Publisher like '%" + Tag + "%' or Abstract like '%" 
                        + Tag + "%' or Name like '%" + Tag + "%' or Issue like '%" + Tag 
                        + "%' or Volume like '%" + Tag + "%' or Notes like '%" + Tag + "%'";
                    txtHeader.Text = " References that are tagged in ";
                }
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
