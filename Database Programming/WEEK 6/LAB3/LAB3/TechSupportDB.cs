using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace LAB3
{
    public static class TechSupportDB
    {
        public static SqlConnection GetConnection()
        {
            string strConn = ConfigurationManager.ConnectionStrings["TECHSUPPORTConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(strConn);
            return conn;
        }
    }
}
