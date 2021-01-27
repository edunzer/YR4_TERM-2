using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LAB2_P2
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
                this.productsTableAdapter.FillByCustomerIDProducts(this.tECHSUPPORTDataSet.Products, intCustomerID);

                if (productsBindingSource.Count == 0)
                {
                    MessageBox.Show("No Customer found.");
                }
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int CustomerID = Convert.ToInt32(customerIDTextBox.Text);
            var DateOpened = Convert.ToDateTime(dateOpenedDateTimePicker.Text);
            var ProductName = comboBox1.Text;
            var ProductCode = Convert.ToString(this.productsTableAdapter.FillByProductCodeFind(this.tECHSUPPORTDataSet.Products, ProductName));
            var Title = titleTextBox.Text;
            var Description = descriptionTextBox.Text;

            this.incidentsTableAdapter.InsertQuery(CustomerID, DateOpened, Title, Description, ProductCode);
            
            /*
            try
            {
                this.incidentsTableAdapter.InsertQuery(CustomerID, ProductCode, DateOpened, Title, Description);

                MessageBox.Show("Update successful." + Convert.ToString(CustomerID) + "Has been added to the incidents table.");
                MessageBox.Show(Convert.ToString(CustomerID) + " " + Convert.ToString(DateOpened) + " " + Convert.ToString(ProductName) + " " + Convert.ToString(ProductCode) + " " + Convert.ToString(Title) + " " + Convert.ToString(Description));

            }
            catch (System.Exception)
            {
                MessageBox.Show("Update failed");
            }
            */
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
