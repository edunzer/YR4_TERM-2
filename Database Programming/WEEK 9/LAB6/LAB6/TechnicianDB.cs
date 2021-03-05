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
    public class TechnicianDB
    {
        private const string Path = @"G:\2-COLLEGE-\YR4_TERM-2\Database Programming\WEEK 9\LAB6\LAB6\Technicians.txt";

        public static List<Technician> GetTechnicians()
        {
            List<Technician> technician = new List<Technician>();

            StreamReader textin = (new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read)));

            while (textin.Peek() != -1)
            {
                string row = textin.ReadLine();
                string[] columns = row.Split('|');
                Technician technicians = new Technician();

                if (technicians.TechID == null)
                {
                    technicians.TechID = null;
                }
                else
                {
                    technicians.TechID = Convert.ToInt32(columns[0]);
                }
                technicians.Name = Convert.ToString(columns[1]);

                technician.Add(technicians);
            }
            textin.Close();
            return technician;
        }
    }
}
