using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LAB3
{
    class CustomerDB
    {
        public static void GetCustomers(Customer customer)
        {
            SqlConnection conn = TechSupportDB.GetConnection();
            string FindCustomers = "SELECT CustomerID, Name FROM Customers";
            SqlCommand cmd = new SqlCommand(FindCustomers, conn);

            try
            {
                conn.Open();
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
