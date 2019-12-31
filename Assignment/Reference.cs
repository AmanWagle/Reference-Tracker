using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Reference
    {
        public string Title
        {
            get;
            set;
        }
        public string Authors_Fname
        {
            get;
            set;
        }
        public string Authors_Lname
        {
            get;
            set;
        }
        public string Document_type
        {
            get;
            set;
        }
        public string Year
        {
            get;
            set;
        }
        public string Publisher
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string Abstract
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Issue
        {
            get;
            set;
        }
        public string Volume
        {
            get;
            set;
        }
        public string Pageno
        {
            get;
            set;
        }
        public string Notes
        {
            get;
            set;
        }
        public int Userid
        {
            get;
            set;
        }

        public bool insert()
        {
            try
            {
                string qry = "insert into tbl_References values ('" + Title + "','" + Authors_Fname + "','" 
                    + Authors_Lname + "','" + Document_type + "','" + Year + "','" + Publisher + "','" 
                    + City + "','" + Abstract + "','" + Name + "','" + Issue + "','" + Volume + "'," 
                    + Pageno + ",'" + Notes + "'," + Userid + ")";
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                dbcon.ExecuteQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
