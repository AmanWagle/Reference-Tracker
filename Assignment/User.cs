using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class User
    {
        DatabaseCon dbcon = new DatabaseCon();

        string fname;
        string surename;
        string gender;
        string address;
        string phone;
        DateTime dob;
        string email;
        string password;


        public string Fname
        {
            get => fname; set => fname = value;
        }
        public string Surename
        {
            get => surename; set => surename = value;
        }
        public string Gender
        {
            get => gender; set => gender = value;
        }
        public string Address
        {
            get => address; set => address = value;
        }
        public string Phone
        {
            get => phone; set => phone = value;
        }
        public DateTime Dob
        {
            get => dob; set => dob = value;
        }
        public string Email
        {
            get => email; set => email = value;
        }
        public string Password
        {
            get => password; set => password = value;
        }

        public bool adduser()
        {
            try
            {
                string qry = "insert into tbl_User values ('" + Fname + "','" + Surename + "','" + Address 
                    + "','" + Gender + "','" + Email + "','" + Phone + "','" + Password + "','" + Dob +"')";
                dbcon.Query = qry;
                dbcon.ExecuteQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
