using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class loginUserdata
    {
        public DataTable login(string email, string pw)
        {
            try
            {
                string qry = "select * from tbl_User where Email= '" + email + "' and Password = '" + pw + "'";
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable userdata(int userid)
        {
            try
            {
                string qry = "select * from tbl_User where ID =" + userid;
                DatabaseCon dbcon = new DatabaseCon();
                dbcon.Query = qry;
                DataTable dt = dbcon.GetData();
                return dt;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
