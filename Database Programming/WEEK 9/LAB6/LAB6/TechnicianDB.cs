using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LAB6
{
    public class TechnicianDB
    {
        public static List<Technician> GetTechnicians()
        {
            List<Technician> technician = new List<Technician>();

            SqlConnection conn = DatabaseDB.GetConnection();
            string select = "SELECT * FROM Technicians";
            SqlCommand cmd = new SqlCommand(select, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Technician technicians = new Technician();

                    technicians.Name = (string)reader["Name"];
                    technicians.TechID = (int)reader["TechID"];

                    technician.Add(technicians);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return technician;
        }
    }
}
