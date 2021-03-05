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
    public class IncidentsDB
    {
        public static List<Incidents> GetIncidents()
        {
            List<Incidents> incidents = new List<Incidents>();

            SqlConnection conn = DatabaseDB.GetConnection();
            string select = "SELECT * FROM Incidents";
            SqlCommand cmd = new SqlCommand(select, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Incidents incident = new Incidents();

                    incident.CustomerID = (int)reader["CustomerID"];
                    incident.DateCLosed = (DateTime)reader["DateCLosed"];
                    incident.DateOpened = (DateTime)reader["DateOpened"];
                    incident.Description = (string)reader["Description"];
                    incident.IncidentID = (int)reader["IncidentID"];
                    incident.ProductCode = (int)reader["ProductCode"];
                    incident.TechID = (int)reader["TechID"];
                    incident.Title = (string)reader["Title"];

                    incidents.Add(incident);
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
            return incidents;
        }
    }
}
