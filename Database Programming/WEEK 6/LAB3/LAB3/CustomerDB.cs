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
            string FindCustomers = "SELECT CustomerID FROM Customers WHERE Name=@Name";
            SqlCommand cmd = new SqlCommand(FindCustomers, conn);

            cmd.Parameters.AddWithValue("@Name", customer.Name);


            try
            {
                conn.Open();
                string CustomerCode = Convert.ToString(cmd.ExecuteScalar());
                
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
