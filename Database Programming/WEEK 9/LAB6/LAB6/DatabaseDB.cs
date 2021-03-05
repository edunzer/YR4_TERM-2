using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LAB6
{
    public class DatabaseDB
    {
        public static SqlConnection GetConnection()
        {
            string strconn = ConfigurationManager.ConnectionStrings["TECHSUPPORTConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
    }
}
