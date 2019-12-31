using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Assignment
{
    public class DatabaseCon
    {
        public string Query
        {
            get;
            set;
        }
        SqlConnection con;

        //constructor
        public DatabaseCon() 
        {
            con = new SqlConnection("Data Source = (local); Initial Catalog=Assignment; Integrated SEcurity = True");
        }

        public int ExecuteQuery()
        {
            SqlCommand cmd = new SqlCommand(Query, con);
            try
            {
                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                    cmd.Connection.Close();
            }
        }

        public DataTable GetData()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(Query, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                    return ds.Tables[0];
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
