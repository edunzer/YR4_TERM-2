using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Incidents> incidentsList = IncidentsDB.GetIncidents();
            List<Technician> techniciansList = TechnicianDB.GetTechnicians();

            var lineitems = from incident in incidentsList
                            join technician in techniciansList
                            on incident.TechID equals technician.TechID
                            orderby technician.Name
                            select new
                            {
                                technician.Name,
                                incident.ProductCode,
                                incident.DateOpened,
                                incident.DateCLosed,
                                incident.Title
                            };
   
            string name = null;
            int i = 0;

            foreach (var lineitem in lineitems)
            {
                if (lineitem.Name != name)
                {
                    lstvItems.Items.Add(lineitem.Name.ToString());
                    lstvItems.Items[i].SubItems.Add(lineitem.ProductCode.ToString());


                    name = lineitem.Name;
                }
                else
                {
                    lstvItems.Items.Add("");
                    lstvItems.Items[i].SubItems.Add("");

                }

                lstvItems.Items[i].SubItems.Add(lineitem.DateOpened.ToString());
                lstvItems.Items[i].SubItems.Add(lineitem.DateCLosed.ToString());
                lstvItems.Items[i].SubItems.Add(lineitem.Title.ToString());
                i += i;
            }
        }
    }
}
