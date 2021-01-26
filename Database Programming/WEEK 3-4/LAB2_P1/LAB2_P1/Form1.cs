using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB2_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tECHSUPPORTDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }


        private void tsbtnGetCustomer_Click(object sender, EventArgs e)
        {
            int intCustomerID = Convert.ToInt32(tstxtbxCustomerID.Text);
            // TODO: This line of code loads data into the 'tECHSUPPORTDataSet.Customers' table. You can move, or remove it, as needed.
            try
            {
                this.customersTableAdapter.FillByCustomerID(this.tECHSUPPORTDataSet.Customers, intCustomerID);

                if (customersBindingSource.Count == 0)
                {
                    MessageBox.Show("No Customer found.");
                }

            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                this.incidentsTableAdapter.FillByCustomerIDIncidents(this.tECHSUPPORTDataSet.Incidents, intCustomerID);

                if (incidentsBindingSource.Count == 0)
                {
                    if (customersBindingSource.Count != 0)
                    {
                        MessageBox.Show("No incidents found for this customer.");
                    }
                    
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

           

        }
    }
}
