using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class UserValidation
    {

        public bool emptyValidation(string str)
        {
            if (string.IsNullOrEmpty(str))
                return false;
            else
                return true;
        }

        public bool emailValidation(string Email)
        {
            if (Email.Contains("@"))
                return true;
            else
                return false;
        }
        public bool passwordValidation(string Password, string ConfirmPassword)
        {
            if (Password == ConfirmPassword)
                return true;
            else
                return false;
        }

        public bool CheckEmail(string Email)
        {
            try
            {
                DatabaseCon dbcon = new DatabaseCon();
                string qry = "select Email from [tbl_User]";
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();

                foreach(DataRow dr in dt.Rows)
                {
                    if (Email == (string)dr["Email"])
                    {
                        return false;
                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
