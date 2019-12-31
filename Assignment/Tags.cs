using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Tags
    {
        public string Tag
        {
            get;
            set;
        }
        public int UserId
        {
            get;
            set;
        }

        public bool insertTag()
        {
            try
            {
                string qry = "insert into tbl_Tags values ('" + Tag + "'," + UserId + ")";
                DatabaseCon dbcon = new DatabaseCon();
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
