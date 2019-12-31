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
    public partial class Home : Form
    {
        private int userId;

        public Home(int id)
        {
            this.userId = id;
            InitializeComponent();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Registration r = new Registration();
            r.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                string qry = "select First_Name from [tbl_User] where ID =" + userId;
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();

                Label lbl_welcome = new Label();
                lbl_welcome.AutoSize = true;
                lbl_welcome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lbl_welcome.Location = new System.Drawing.Point(20, 45);
                lbl_welcome.Size = new System.Drawing.Size(188, 43);
                lbl_welcome.Text = "Welcome, " + dt.Rows[0]["First_Name"].ToString() + "!!!";
                this.Controls.Add(lbl_welcome);

                combo_style.Items.Add("Harvard");
                combo_style.Items.Add("APA");
                combo_style.Items.Add("Chicago");
                combo_style.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void viewreference(string style, string query)
        {
            try
            {
                string qry = "";
                if (!string.IsNullOrEmpty(query))
                {
                    qry = query;
                }
                else
                {
                    qry = "select * from tbl_References where UserId =" + userId;
                }
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();
                panel1.Controls.Clear();

                int y = 10;
                foreach (DataRow dr in dt.Rows)
                {
                    string title = (string)dr["Title"];
                    string authorsFname = (string)dr["Authors_Fname"];
                    string authorsLname = (string)dr["Authors_Lname"];
                    string documentType = (string)dr["Document_type"];
                    string year = (string)dr["Year"];
                    string Publisher = (string)dr["Publisher"];
                    string City = (string)dr["City"];
                    string Abstract = (string)dr["Abstract"];
                    string name = (string)dr["Name"];
                    string issue = (string)dr["Issue"];
                    string volume = (string)dr["Volume"];
                    int pageno = Convert.ToInt32(dr["Page_no"].ToString());
                    authorsFname = authorsFname.Substring(0, 1);


                    RichTextBox txt1 = new RichTextBox();
                    txt1.BorderStyle = BorderStyle.None;
                    txt1.Location = new Point(90, y);
                    txt1.Width = 1000;
                    txt1.Height = 30;
                    txt1.ReadOnly = true;
                    txt1.Font = new Font(FontFamily.GenericSansSerif, 16, FontStyle.Regular);
                    y = y + 30;

                    if (style == "Harvard")
                    {
                        if (documentType == "Book")
                        {
                            //Last name, First initial. (Year published).Title. City published: Publisher, Page(s).
                            txt1.Text = authorsLname + ", " + authorsFname + ". " + "(" + year + ")." + name
                                + ". " + City + ": " + Publisher + ", " + pageno + ".";
                            this.makeItalic(name, txt1);
                        }
                        else if (documentType == "Journal")
                        {
                            //Last name, First initial. (Year published). Article title. Journal, Volume (Issue), 
                            //Page(s).
                            txt1.Text = authorsLname + ", " + authorsFname + ". " + "(" + year + ")." + title + ". "
                                + name + ", " + volume + "(" + issue + ")" + pageno + ".";
                            this.makeItalic(name, txt1);
                        }
                        else if (documentType == "Conference Processing")
                        {
                            //Last name, First initial. (Conference Year). Title of Paper or Proceedings. 
                            //In: Name or Title of Conference. City: Publisher of the Proceedings, pages.
                            txt1.Text = authorsLname + ", " + authorsFname + ". " + "(" + year + ")." + title
                                + ". In:" + name + ". " + City + ":" + Publisher + ", " + pageno + ".";
                            this.makeItalic(name, txt1);
                        }
                    }

                    else if (style == "APA")
                    {
                        if (documentType == "Book")
                        {
                            //Author, A. (Year of Publication). Title of work. Publisher City : Publisher.
                            txt1.Text = authorsLname + "," + authorsFname + "." + "(" + year + "). " + name
                                + ". " + City + ":" + Publisher + ".";
                            this.makeItalic(name, txt1);
                        }
                        else if (documentType == "Journal")
                        {
                            //Last, FN. (Year Published). Article title. Journal Name, Volume(Issue),  Pages.
                            txt1.Text = authorsLname + ", " + authorsFname + ". " + "(" + year + ")." + title
                                + ". " + name + ", " + volume + "(" + issue + ")" + pageno + ".";
                            this.makeItalic(name, txt1);
                        }
                        else if (documentType == "Conference Processing")
                        {
                            //Last name, FN. (Year published). Title of Paper or Proceedings, Title of Conference,
                            //Issue. Place of publication: Publisher.
                            txt1.Text = authorsLname + ", " + authorsFname + ". " + "(" + year + ")." + title
                                + ", " + name + ", " + issue + ", " + City + ": " + Publisher + ".";
                            this.makeItalic(name, txt1);
                            this.makeItalic(volume, txt1);
                        }
                    }

                    else if (style == "Chicago")
                    {
                        if (documentType == "Book")
                        {
                            //Last Name, First Name. Title of Book. Publisher City: Publisher Name, Year Published.
                            txt1.Text = authorsLname + "," + authorsFname + ". " + name + ". " + City + ": "
                                + Publisher + ", " + year + ".";
                            this.makeItalic(name, txt1);
                        }
                        else if (documentType == "Journal")
                        {
                            //Last name, First name. “Article Title.” Journal Title, volume, no. issue 
                            //(year of publication). Pages.
                            txt1.Text = authorsLname + "," + authorsFname + ". '" + title + ".' " + name + ", "
                                + volume + ", " + issue + "(" + year + "). " + pageno + ".";
                            this.makeItalic(name, txt1);
                        }
                        else if (documentType == "Conference Processing")
                        {
                            //Last name, First name. “Title of the Paper.” Paper presented at the Title of 
                            //the Conference, Location of Conference, Year of Conference.
                            txt1.Text = authorsLname + "," + authorsFname + ". '" + title + ".' " + name
                                + ", " + City + ", " + year + ".";
                        }
                    }

                    else
                    {
                        MessageBox.Show("Please select valid referencing style.");
                    }
                    panel1.Controls.Add(txt1);
                    panel1.AutoScroll = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to log out?",
            "The Question", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result1 == DialogResult.Yes)
            {
                this.Close();
                Login l = new Login();
                l.Show();
            }
            else
            {
                //nothing
            }
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profile p = new Profile(userId);
            p.Show();
            this.Close();
        }

        private void addReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Reference ar = new Add_Reference(userId);
            ar.Show();
        }


        private void addTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Add_Tags at = new Add_Tags(userId);
            at.Show();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_style.Text == "Harvard")
            {
                panel1.Controls.Clear();
                viewreference("Harvard", "");
            }
            else if (combo_style.Text == "APA")
            {
                panel1.Controls.Clear();
                viewreference("APA", "");
            }
            else if (combo_style.Text == "Chicago")
            {
                panel1.Controls.Clear();
                viewreference("Chicago", "");
            }
            else
            {
                panel1.Controls.Clear();
                MessageBox.Show("Select Referencing style as your need.");
            }

        }

        public void makeItalic(string word, RichTextBox txt1)
        {

            int index = -1;
            int selectStart = txt1.SelectionStart;
            int startIndex = 0;
            while ((index = txt1.Text.IndexOf(word, (index + 1))) != -1)
            {
                txt1.Select((index + startIndex), word.Length);
                txt1.SelectionFont = new Font(FontFamily.GenericMonospace, 16, FontStyle.Italic);
                txt1.Select(selectStart, 0);
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            string search = txt_search.Text;
            string qry = "";

            if (!string.IsNullOrEmpty(search))
            {
                qry = "select * from [tbl_References] where UserId =" + userId + "and Title like '%"
                    + search + "%' or Authors_Fname like '%" + search + "%' or Authors_Lname like '%"
                    + search + "%' or Document_type like '%" + search + "%' or Year like '%" + search
                    + "%' or Publisher like '%" + search + "%' or Abstract like '%" + search
                    + "%' or Name like '%" + search + "%' or Issue like '%" + search + "%' or Volume like '%"
                    + search + "%' or Notes like '%" + search + "%'";
            }
            else
            {
                qry = "";
            }
            viewreference(combo_style.SelectedItem.ToString(), qry);
        }

        private void combo_sorting_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string sorting_style = "";
            if (combo_sorting.SelectedItem.ToString() == "Title")
                sorting_style = "Title";
            else if (combo_sorting.SelectedItem.ToString() == "Journal")
                sorting_style = "Name";
            else if (combo_sorting.SelectedItem.ToString() == "Year")
                sorting_style = "Year";
            else if (combo_sorting.SelectedItem.ToString() == "Author's First Name")
                sorting_style = "Authors_Fname";
            else if (combo_sorting.SelectedItem.ToString() == "Author's Surname")
                sorting_style = "Authors_Lname";
            else
                MessageBox.Show("Select sorting style.");

            string qry = "Select * from tbl_References Where UserId=" + userId + " Order By " + sorting_style;
            viewreference(combo_style.SelectedItem.ToString(), qry);
        }

        private void exportRefetencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Export ex = new Export(userId);
            ex.Show();
        }

        private void viewMyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            View_myReferences vr = new View_myReferences(userId);
            vr.Show();
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewAllReferences var = new viewAllReferences();
            var.Show();
        }

        private void viewMyTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            ViewMyTags vt = new ViewMyTags(userId);
            vt.Show();
        }

        private void viewAllTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllTags vat = new ViewAllTags();
            vat.Show();
        }
    }
}
