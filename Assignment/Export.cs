using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Export : Form
    {
        int userId;
        public Export(int uid)
        {
            userId = uid;
            InitializeComponent();
        }


        private void Export_Load(object sender, EventArgs e)
        {
            combo_Export.Items.Add("Harvard");
            combo_Export.Items.Add("APA");
            combo_Export.Items.Add("Chicago");
            combo_Export.SelectedIndex = 0;
            try
            {
                string qry = "select * from tbl_References where UserId =" + userId;
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

        private void btn_export_Click(object sender, EventArgs e)
        {

            if (combo_Export.SelectedItem != null)
            {
                SaveFileDialog fd = new SaveFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    fd.DefaultExt = ".txt";
                    string selectedStyle = combo_Export.SelectedItem.ToString();
                    StreamWriter sw = new StreamWriter(fd.FileName + "." +fd.DefaultExt );
                    try
                    {
                        bool isSelected = false;

                        foreach (DataGridViewRow drv in dataGridView1.Rows)
                        {
                            var chk = Convert.ToBoolean(drv.Cells["export_check"].Value);
                            string citationStyle="";

                            if (chk)
                            {
                                string title = drv.Cells["Title"].Value.ToString();
                                string authorsFname = drv.Cells["Authors_Fname"].Value.ToString();
                                string authorsLname = drv.Cells["Authors_Lname"].Value.ToString();
                                string documentType = drv.Cells["Document_type"].Value.ToString();
                                string year = drv.Cells["Year"].Value.ToString();
                                string Publisher = drv.Cells["Publisher"].Value.ToString();
                                string City = drv.Cells["City"].Value.ToString();
                                string name = drv.Cells["Name"].Value.ToString();
                                string issue = drv.Cells["Issue"].Value.ToString();
                                string volume = drv.Cells["Volume"].Value.ToString();
                                string pageno = drv.Cells["Page_no"].Value.ToString();
                                authorsFname = authorsFname.Substring(0, 1);

                                isSelected = true;
                                if (selectedStyle == "Harvard")
                                {
                                    if (documentType == "Book")
                                    {
                                        //Last name, First initial. (Year published).Title. City published: 
                                        //Publisher, Page(s).
                                        citationStyle = authorsLname + ", " + authorsFname + ". " 
                                            + "(" + year + ")." + name + ". " + City + ": " + Publisher 
                                            + ", " + pageno + ".";
                                    }
                                    else if (documentType == "Journal")
                                    {
                                        //Last name, First initial. (Year published). Article title. 
                                        //Journal, Volume (Issue), Page(s).
                                        citationStyle = authorsLname + ", " + authorsFname + ". " + "(" + year 
                                            + ")." + title + ". " + name + ", " + volume + "(" + issue + ")" 
                                            + pageno + ".";
                                    }
                                    else if (documentType == "Conference Processing")
                                    {
                                        //Last name, First initial. (Conference Year). Title of Paper or 
                                        //Proceedings. In: Name or Title of Conference. City: Publisher of 
                                        //the Proceedings, pages.
                                        citationStyle = authorsLname + ", " + authorsFname + ". " + "(" + year 
                                            + ")." + title + ". In:" + name + ". " + City + ":" + Publisher 
                                            + ", " + pageno + ".";
                                    }
                                }
                                else if (selectedStyle == "APA")
                                {
                                    if (documentType == "Book")
                                    {
                                        //Author, A. (Year of Publication). Title of work. Publisher City :
                                        //Publisher.
                                        citationStyle = authorsLname + "," + authorsFname + "." + "(" + year 
                                            + "). " + name + ". " + City + ":" + Publisher + ".";

                                    }
                                    else if (documentType == "Journal")
                                    {
                                        //Last, FN. (Year Published). Article title. Journal Name, Volume(Issue),
                                        //Pages.
                                        citationStyle = authorsLname + ", " + authorsFname + ". " + "(" 
                                            + year + ")." + title + ". " + name + ", " + volume + "(" + issue 
                                            + ")" + pageno + ".";
                                    }
                                    else if (documentType == "Conference Processing")
                                    {
                                        //Last name, FN. (Year published). Title of Paper or Proceedings, 
                                        //Title of Conference, Issue. Place of publication: Publisher.
                                        citationStyle = authorsLname + ", " + authorsFname + ". " + "(" + year 
                                            + ")." + title + ", " + name + ", " + issue + ", " + City + ": " 
                                            + Publisher + ".";
                                    }
                                }
                                else if (selectedStyle == "Chicago")
                                {
                                    if (documentType == "Book")
                                    {
                                        //Last Name, First Name. Title of Book. Publisher City: 
                                        //Publisher Name, Year Published.
                                        citationStyle = authorsLname + "," + authorsFname + ". " + name 
                                            + ". " + City + ": " + Publisher + ", " + year + ".";
                                    }
                                    else if (documentType == "Journal")
                                    {
                                        //Last name, First name. “Article Title.” Journal Title, 
                                        //volume, no. issue (year of publication). Pages.
                                        citationStyle = authorsLname + "," + authorsFname + ". '" + title 
                                            + ".' " + name + ", " + volume + ", " + issue + "(" + year + "). " 
                                            + pageno + ".";
                                    }
                                    else if (documentType == "Conference Processing")
                                    {
                                        //Last name, First name. “Title of the Paper.” Paper presented at 
                                        //the Title of the Conference, Location of Conference, Year of Conference.
                                        citationStyle = authorsLname + "," + authorsFname + ". '" + title + ".' " 
                                            + name + ", " + City + ", " + year + ".";
                                    }
                                }
                            }
                            sw.WriteLine(citationStyle);
                        }
                        if (isSelected)
                            MessageBox.Show("References are successfull exported into " + selectedStyle 
                                + " Citation in File location: " + fd.FileName +"." + fd.DefaultExt);
                        else
                            MessageBox.Show("There is no reference selected");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Export_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home h = new Home(userId);
            h.Show();
        }
    }
}
