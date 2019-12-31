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
    public partial class Edit_References : Form
    {
        private int referenceId;
        public Edit_References(int ref_id)
        {
            referenceId = ref_id;
            InitializeComponent();
        }

        public int userID
        {
            get;
            set;
        }

        private void Edit_References_Load(object sender, EventArgs e)
        {
            string qry = "select * from tbl_References where Ref_Id =" + referenceId;
            DatabaseCon dbcon = new DatabaseCon();
            dbcon.Query = qry;
            DataTable dt = dbcon.GetData();
            if (dt.Rows.Count > 0)
            {
                txtTitle.Text = dt.Rows[0]["Title"].ToString();
                txtAuthors_Fname.Text = dt.Rows[0]["Authors_Fname"].ToString();
                txtAuthors_Lname.Text = dt.Rows[0]["Authors_Lname"].ToString();
                txtDocumenttype.Text = dt.Rows[0]["Document_type"].ToString();
                txtYear.Text = dt.Rows[0]["Year"].ToString();
                txtPublisher.Text = dt.Rows[0]["Publisher"].ToString();
                txtCity.Text = dt.Rows[0]["Publisher"].ToString();
                txtAbstract.Text = dt.Rows[0]["Abstract"].ToString();
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtIssue.Text = dt.Rows[0]["Issue"].ToString();
                txtVolume.Text = dt.Rows[0]["Volume"].ToString();
                txtPageno.Text = dt.Rows[0]["Page_no"].ToString();
                txtNotes.Text = dt.Rows[0]["Notes"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ReferencesValidation rv = new ReferencesValidation();

            string[] parameters = new string[] { txtTitle.Text, txtAuthors_Fname.Text, txtAuthors_Fname.Text,
                txtDocumenttype.Text, txtYear.Text, txtPublisher.Text, txtAbstract.Text, txtName.Text,
                txtIssue.Text, txtVolume.Text, txtPageno.Text };
            if (rv.checkEmpty(parameters) == true)
            {
                    if (rv.numberValid(txtPageno.Text) == true)
                    {
                        try
                        {
                            string qry = "update tbl_References set Title ='" + txtTitle.Text 
                            + "', Authors_Fname ='" + txtAuthors_Fname.Text + "', Authors_Lname ='" 
                            + txtAuthors_Lname.Text +"', Document_type ='" + txtDocumenttype.Text 
                            + "', Year ='" + txtYear.Text + "', Publisher ='" + txtPublisher.Text  
                            + "', City ='" + txtCity.Text + "', Abstract ='" + txtAbstract.Text 
                            + "', Name ='" + txtName.Text + "', Issue ='" + txtIssue.Text + "', Volume ='" 
                            + txtVolume.Text + "', Page_no =" + int.Parse(txtPageno.Text) + ", Notes ='" 
                            + txtNotes.Text + "' where Ref_Id =" + referenceId;
                            DatabaseCon dbcon = new DatabaseCon();
                            dbcon.Query = qry;
                            dbcon.ExecuteQuery();
                            MessageBox.Show("Done.");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter numberic value for Page number.");
                        txtPageno.Focus();
                    }
            }
            else
            {
                MessageBox.Show("Don't leave any field with * empty.");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Edit_References_FormClosing(object sender, FormClosingEventArgs e)
        {
            View_myReferences v = new View_myReferences(userID);
            v.Show();
        }
    }
}
