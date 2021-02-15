using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LAB3
{
    class ProductDB
    {
        public static void GetProducts(Product product)
        {
            SqlConnection conn = TechSupportDB.GetConnection();
            string FindProducts = "SELECT ProductCode FROM Products WHERE Name=@Name";
            SqlCommand cmd = new SqlCommand(FindProducts, conn);

            cmd.Parameters.AddWithValue("@Name", product.Name);

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
