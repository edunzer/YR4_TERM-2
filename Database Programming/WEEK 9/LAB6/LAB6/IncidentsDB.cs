using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace LAB6
{
    public class IncidentsDB
    {
        private const string Path = @"G:\2-COLLEGE-\YR4_TERM-2\Database Programming\WEEK 9\LAB6\LAB6\Incidents.txt";

        public static List<Incidents> GetIncidents()
        {
            List<Incidents> incidents = new List<Incidents>();

            StreamReader textin = (new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)));

            while (textin.Peek() != -1)
            {
                string row = textin.ReadLine();
                string[] columns = row.Split('|');
                Incidents incident = new Incidents();

                incident.CustomerID = Convert.ToInt32(columns[0]);
                incident.IncidentID = Convert.ToInt32(columns[1]);
                incident.ProductCode = Convert.ToString(columns[2]);
                if (incident.TechID == null)
                {
                    incident.TechID = null;
                }
                else
                {
                    incident.TechID = Convert.ToInt32(columns[3]);
                }
                if (incident.DateCLosed == null)
                {
                    incident.DateCLosed = null;
                }
                else
                {
                    incident.DateCLosed = Convert.ToDateTime(columns[4]);
                }
                if (incident.DateOpened == null)
                {
                    incident.DateOpened = null;
                }
                else
                {
                    incident.DateOpened = Convert.ToDateTime(columns[5]);
                }
                incident.Title = Convert.ToString(columns[6]);
                incident.Description = Convert.ToString(columns[7]);

                incidents.Add(incident);
            }
            textin.Close();
            return incidents;
        }
    }
}
