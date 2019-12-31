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
    public partial class Add_Tags : Form
    {
        private int userid;
        public Add_Tags(int uid)
        {
            userid = uid;
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tags t = new Tags();
            t.Tag = txtTag.Text;
            t.UserId = userid;

            t.insertTag();
            MessageBox.Show("Done");
            txtTag.Clear();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_Tags_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home h = new Home(userid);
            h.Show();
        }
    }
}
