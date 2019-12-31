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
    public partial class Add_Reference : Form
    {
        private int userid;
        public Add_Reference(int user_id)
        {
            userid = user_id;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Reference r = new Reference();

            r.Title = txtTitle.Text;
            r.Authors_Fname = txtAuthors_Fname.Text;
            r.Authors_Lname = txtAuthors_Lname.Text;
            r.Document_type = txtDocumenttype.Text;
            r.Year = txtYear.Text;
            r.Publisher = txtPublisher.Text;
            r.City = txtCity.Text;
            r.Abstract = txtAbstract.Text;
            r.Name = txtName.Text;
            r.Issue = txtIssue.Text;
            r.Volume = txtVolume.Text;
            r.Pageno = txtPageno.Text;
            r.Notes = txtNotes.Text;
            r.Userid = userid;

            ReferencesValidation rv = new ReferencesValidation();

            string[] parameters = new string[] { txtTitle.Text, txtAuthors_Fname.Text, txtAuthors_Lname.Text,
                txtDocumenttype.Text, txtYear.Text, txtPublisher.Text, txtAbstract.Text, txtName.Text,
                txtIssue.Text, txtVolume.Text, txtPageno.Text };
            if (rv.checkEmpty(parameters) == true)
            {
                if (rv.numberValid(txtVolume.Text) == true)
                {
                    if (rv.numberValid(txtPageno.Text) == true)
                    {
                        r.insert();
                        MessageBox.Show("Reference added sucessfully.");
                        formclear();
                    }
                    else
                    {
                        MessageBox.Show("Please enter numberic value for Page number.");
                        txtPageno.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter numberic value for Page number.");
                    txtVolume.Focus();
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

        private void Add_Reference_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home h = new Home(userid);
            h.Show();
        }
        
        private void formclear()
        {
            txtTitle.Clear();
            txtAuthors_Fname.Clear();
            txtAuthors_Lname.Clear();
            txtDocumenttype.SelectedItem = null;
            txtYear.Clear();
            txtPublisher.Clear();
            txtCity.Clear();
            txtAbstract.Clear();
            txtName.Clear();
            txtIssue.Clear();
            txtVolume.Clear();
            txtPageno.Clear();
            txtNotes.Clear();
        }


        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            ReferencesValidation r = new ReferencesValidation();
            if (r.yearValid(txtYear.Text)==false)
            {
                MessageBox.Show("Please enter is YYYY format.");
                txtYear.Focus();
            }
        }
    }
}
