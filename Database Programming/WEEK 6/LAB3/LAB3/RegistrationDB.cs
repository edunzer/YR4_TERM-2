using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LAB3
{
    class RegistrationDB
    {
        public static void AddRegistration(Registration registration)
        {
            SqlConnection conn = TechSupportDB.GetConnection();

            string strInsert = "INSERT INTO Registrations " + 
                "(CustomerID, ProductCode, RegistrationDate)" +
                "Values (@CustomerID, @ProductCode, @Date)";

            SqlCommand cmd = new SqlCommand(strInsert, conn);

            cmd.Parameters.AddWithValue("@CustomerID", registration.CustID);
            cmd.Parameters.AddWithValue("@ProductCode", registration.ProdCode);
            cmd.Parameters.AddWithValue("@Date", registration.RegDate);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Added", "Success");
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
